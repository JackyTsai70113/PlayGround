namespace playground;

public class AddTwoNumbers0002
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers
    /// </summary>
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        ListNode res = new(), cur = res;
        while (l1 != null || l2 != null || carry > 0)
        {
            int total = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
            cur.next = new(total % 10);
            carry = total / 10;
            cur = cur.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        return res.next;
    }
}
