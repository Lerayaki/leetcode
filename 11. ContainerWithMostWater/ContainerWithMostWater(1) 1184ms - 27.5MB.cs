public class Solution {
    public int MaxArea(int[] height) {
        int vol = 0;

        for (int i=0; i<height.Length; i++) {
            for (int j=i+1; j<height.Length; j++) {
                vol = Math.Max(vol, (j-i)*Math.Min(height[i], height[j]));
            }
        }

        return vol;
    }
}
