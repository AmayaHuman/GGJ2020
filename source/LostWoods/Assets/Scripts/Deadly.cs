using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deadly : MonoBehaviour
{
    public static bool death_enabled = true;
    private GameObject player_inside;
    public GameObject die_teleport_target;
    private bool respawn_finished = false;
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
        player_inside = null;

    }

    // Update is called once per frame
    void Update()
    {

        if (respawn_finished)
        {
            player_inside = null;
            StopCoroutine(Respawn());
            respawn_finished = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (death_enabled && other.gameObject.tag == "Player")
        {
            player_inside = other.gameObject;
            StartCoroutine(Respawn());
        }
    }



    IEnumerator Respawn()
    {
        CharacterController controller = player_inside.GetComponent<CharacterController>();
        UnityStandardAssets.Characters.FirstPerson.FirstPersonController player_script = (UnityStandardAssets.Characters.FirstPerson.FirstPersonController)player_inside.GetComponent("FirstPersonController");


        if (controller != null) { controller.enabled = false; }
        if (player_script != null) { player_script.enabled = false; }
        // loop over 1 second backwards
        for (float i = 0; i < 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, i);
            player_inside.transform.Rotate(0, 0, Time.deltaTime * 90);
            yield return null;
        }


        player_inside.transform.position = die_teleport_target.transform.position;
        player_inside.transform.rotation = die_teleport_target.transform.rotation;

        yield return null;

        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(1, 1, 1, 1 - i);
            yield return null;
        }

        img.color = new Color(1, 1, 1, 0);
        if (controller != null) { controller.enabled = true; }
        if (player_script != null) { player_script.enabled = true; player_script.Reset(); }
        respawn_finished = true;
        yield break;
    }
}
