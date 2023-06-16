using UnityEngine;

public class RecordAnimation : MonoBehaviour
{
    public AnimationClip clip;
    private float time;

    void Update()
    {
        // Add keyframes to animation clip every frame
        AnimationCurve posXCurve = AnimationCurve.Linear(time, transform.position.x, time + Time.deltaTime, transform.position.x);
        AnimationCurve posYCurve = AnimationCurve.Linear(time, transform.position.y, time + Time.deltaTime, transform.position.y);
        AnimationCurve posZCurve = AnimationCurve.Linear(time, transform.position.z, time + Time.deltaTime, transform.position.z);
        AnimationCurve rotXCurve = AnimationCurve.Linear(time, transform.rotation.eulerAngles.x, time + Time.deltaTime, transform.rotation.eulerAngles.x);
        AnimationCurve rotYCurve = AnimationCurve.Linear(time, transform.rotation.eulerAngles.y, time + Time.deltaTime, transform.rotation.eulerAngles.y);
        AnimationCurve rotZCurve = AnimationCurve.Linear(time, transform.rotation.eulerAngles.z, time + Time.deltaTime, transform.rotation.eulerAngles.z);
        clip.SetCurve("", typeof(Transform), "localPosition.x", posXCurve);
        clip.SetCurve("", typeof(Transform), "localPosition.y", posYCurve);
        clip.SetCurve("", typeof(Transform), "localPosition.z", posZCurve);
        clip.SetCurve("", typeof(Transform), "localRotation.x", rotXCurve);
        clip.SetCurve("", typeof(Transform), "localRotation.y", rotYCurve);
        clip.SetCurve("", typeof(Transform), "localRotation.z", rotZCurve);

        // Increment time
        time += Time.deltaTime;
    }
}
