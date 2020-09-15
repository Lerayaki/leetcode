public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length-1;
        int vol = 0;
        
        while (l < r){
            vol = Math.Max(vol, Math.Min(height[l], height[r])*(r-l));
            if (height[l] > height[r])
                r--;
            else
                l++;
        }

        return vol;
    }
}
