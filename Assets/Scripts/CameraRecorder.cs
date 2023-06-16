using UnityEngine;

public class CameraRecorder : MonoBehaviour
{
    public Animation animation;
    public float recordingTime = 1f;

    private Vector3 prevPos;

    void Update()
    {
        // Record animation if camera position has changed
        if (transform.position != prevPos)
        {
            animation.Stop();
            animation.clip = new AnimationClip();
            animation.clip.legacy = true;
            animation.clip.SetCurve("", typeof(Transform), "localPosition.x", AnimationCurve.Linear(0, transform.position.x, recordingTime, transform.position.x));
            animation.clip.SetCurve("", typeof(Transform), "localPosition.y", AnimationCurve.Linear(0, transform.position.y, recordingTime, transform.position.y));
            animation.clip.SetCurve("", typeof(Transform), "localPosition.z", AnimationCurve.Linear(0, transform.position.z, recordingTime, transform.position.z));
            animation.Play();
        }
        else
        {
            animation.Stop();
        }

        // Update previous position of camera
        prevPos = transform.position;
    }
}
