public class Solution {
    public void MoveZeroes(int[] nums) {
        int insertPos = 0; 

    // Всего один цикл
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            // Меняем местами текущий элемент и элемент на insertPos
            int temp = nums[i];
            nums[i] = nums[insertPos];
            nums[insertPos] = temp;

            insertPos++; // Сдвигаем позицию для следующего ненулевого элемента
        }
    }
    }
}