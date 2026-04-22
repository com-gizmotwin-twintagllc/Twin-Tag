using UnityEngine;
using easyInputs;

public class PullMod : MonoBehaviour
{
	[SerializeField] private float MaxJumpSpeed = 10f;
	[SerializeField] private float PullVelocity = 18f;
	[SerializeField] private Rigidbody GorillaPlayer;
	[SerializeField] private EasyHand Hand;

	private void Update()
	{
		if (EasyInputs.GetGripButtonDown(Hand))
		{
			GorillaLocomotion.Player.Instance.maxJumpSpeed = MaxJumpSpeed;
			if (GorillaLocomotion.Player.Instance.wasLeftHandTouching || GorillaLocomotion.Player.Instance.wasRightHandTouching)
			{
				Vector3 velocity = GorillaPlayer.velocity;
				GorillaLocomotion.Player.Instance.transform.position += new Vector3(velocity.x / PullVelocity, velocity.y / PullVelocity, velocity.z / PullVelocity);
			}
		}
	}
}
