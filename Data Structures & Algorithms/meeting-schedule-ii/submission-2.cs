/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) 
    {
        if(intervals.Count == 0)
        {
            return 0;
        }
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        pq.Enqueue(intervals[0].end, intervals[0].end);

        int rooms = 1;        
        
        for(int i=1; i<intervals.Count; i++)
        {
            int start = intervals[i].start;
            int end = intervals[i].end;

            // not overlapping then remove it from heap
            if(pq.Peek() <= start)
            {
                pq.Dequeue();
            }
            pq.Enqueue(end, end);
            rooms = Math.Max(rooms, pq.Count);
        }
        
        return rooms;
    }
}





// public class Solution {
//     public int MinMeetingRooms(List<Interval> intervals) 
//     {
//         if(intervals.Count == 0)
//         {
//             return 0;
//         }
        
//         int maxEnd = intervals[0].end;;
//         for(int i=1; i<intervals.Count; i++)
//         {
//             maxEnd = Math.Max(maxEnd, intervals[i].end);
//         }

//         int[] Arr = new int[maxEnd+1];
//         for(int i=0; i<intervals.Count; i++)
//         {
//             int start = intervals[i].start;
//             int end = intervals[i].end;

//             Arr[start] += 1;
//             Arr[end] -= 1;           
//         }

//         for(int i=1; i<Arr.Length; i++)
//         {
//             Arr[i] = Arr[i-1] + Arr[i];
//         }

//         int rooms = 0;
//         for(int i=0; i<Arr.Length; i++)
//         {
//             rooms = Math.Max(rooms, Arr[i]);
//         }
//         return rooms;
//     }
// }
