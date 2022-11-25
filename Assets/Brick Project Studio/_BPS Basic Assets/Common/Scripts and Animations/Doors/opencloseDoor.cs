using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;

		void Start()
		{
			open = false;
		}

		void Update() {
			{
				if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 3)
					{
						if (open == false)
						{
							if (OVRInput.Get(OVRInput.Button.One))
							{
								StartCoroutine(opening());
							}
						}
						else
						{
							if (open == true)
							{
								if (OVRInput.Get(OVRInput.Button.One))
								{
									StartCoroutine(closing());
								}
							}

						}

					}
				}

			}	
		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.9f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.9f);
		}


	}
}