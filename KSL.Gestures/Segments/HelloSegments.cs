namespace KSL.Gestures.Segments
{
    using KSL.Gestures.Core;
    using Microsoft.Kinect;
    using System;

    public class HelloSegment1 : IGesturesSegment
    {
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            //Console.Write("in trail class###############################################33s\n");
            // Right hand in form of head.
            if (skeleton.Joints[JointType.HandRight].Position.Z < skeleton.Joints[JointType.Head].Position.Z)
            {
                // Right hand above shoulder center.
                if (skeleton.Joints[JointType.HandRight].Position.Y > skeleton.Joints[JointType.ShoulderCenter].Position.Y)
                {
                    // Right hand left of right shoulder.
                    if (skeleton.Joints[JointType.HandRight].Position.X < skeleton.Joints[JointType.ShoulderRight].Position.X)
                    {
                        return GesturePartResult.Succeed;
                    }

                    return GesturePartResult.Pausing;
                }

                return GesturePartResult.Fail;
            }

            return GesturePartResult.Fail;
        }
    }

    public class HelloSegment2 : IGesturesSegment
    {
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            
            // Right hand in form of head.
            if (skeleton.Joints[JointType.HandRight].Position.Z < skeleton.Joints[JointType.Head].Position.Z)
            {
               // Console.Write("in Hello class###############################################33s\n");
                // Right hand above shoulder center.
                if (skeleton.Joints[JointType.HandRight].Position.Y > skeleton.Joints[JointType.ShoulderCenter].Position.Y)
                {
                    // Right hand right of right shoulder.
                    if (skeleton.Joints[JointType.HandRight].Position.X > skeleton.Joints[JointType.ShoulderRight].Position.X)
                    {
                        return GesturePartResult.Succeed;
                    }

                    return GesturePartResult.Pausing;
                }

                return GesturePartResult.Fail;
            }

            return GesturePartResult.Fail;
        }
    }
}
