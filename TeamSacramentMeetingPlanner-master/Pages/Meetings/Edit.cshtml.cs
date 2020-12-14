using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamSacramentMeetingPlanner.Data;
using TeamSacramentMeetingPlanner.Models;

namespace TeamSacramentMeetingPlanner.Pages.Meetings
{
    public class EditModel : PageModel
    {
        private readonly TeamSacramentMeetingPlanner.Data.TeamSacramentMeetingPlannerContext _context;

        public EditModel(TeamSacramentMeetingPlanner.Data.TeamSacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meeting Meeting { get; set; }
        public IEnumerable<SelectListItem> Hymns { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Hymns = GetHymns();
            if (id == null)
            {
                return NotFound();
            }

            Meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.Id == id);

            if (Meeting == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Meeting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeetingExists(Meeting.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MeetingExists(int id)
        {
            return _context.Meeting.Any(e => e.Id == id);
        }

        public IEnumerable<SelectListItem> GetHymns()
        {
            List<SelectListItem> hymns = new List<SelectListItem>();
            hymns.Add(new SelectListItem() { Text = "1. The Morning Breaks", Value = "1. The Morning Breaks" });
            hymns.Add(new SelectListItem() { Text = "2. The Spirit of God", Value = "2. The Spirit of God" });
            hymns.Add(new SelectListItem() { Text = "3. Now Let Us Rejoice", Value = "3. Now Let Us Rejoice" });
            hymns.Add(new SelectListItem() { Text = "4. Truth Eternal", Value = "4. Truth Eternal" });
            hymns.Add(new SelectListItem() { Text = "5. High On A Mountain Top", Value = "5. High On A Mountain Top" });
            hymns.Add(new SelectListItem() { Text = "6. Redeemer of Israel", Value = "6. Redeemer of Israel" });
            hymns.Add(new SelectListItem() { Text = "7. Israel, Israel, God Is Calling", Value = "7. Israel, Israel, God Is Calling" });
            hymns.Add(new SelectListItem() { Text = "8. Awake and Arise", Value = "8. Awake and Arise" });
            hymns.Add(new SelectListItem() { Text = "9. Come, Rejoice", Value = "9. Come, Rejoice" });
            hymns.Add(new SelectListItem() { Text = "10 Come, Sing to the Lord", Value = "10 Come, Sing to the Lord" });
            hymns.Add(new SelectListItem() { Text = "11. What Was Witnessed in the Heavens?", Value = "11. What Was Witnessed in the Heavens?" });
            hymns.Add(new SelectListItem() { Text = "12.'Twas Witnessed in the Morning Sky", Value = "12.'Twas Witnessed in the Morning Sky" });
            hymns.Add(new SelectListItem() { Text = "13. And Angel from on High", Value = "13. And Angel from on High" });
            hymns.Add(new SelectListItem() { Text = "14. Sweet Is the Peace the Gospel Brings", Value = "14. Sweet Is the Peace the Gospel Brings" });
            hymns.Add(new SelectListItem() { Text = "15. I Saw a Mighty Angel Fly", Value = "15. I Saw a Mighty Angel Fly" });
            hymns.Add(new SelectListItem() { Text = "16. What Glorious Scenes Mine Eyes Behold", Value = "16. What Glorious Scenes Mine Eyes Behold" });
            hymns.Add(new SelectListItem() { Text = "17. Awake, Ye Saints of God, Awake!", Value = "17. Awake, Ye Saints of God, Awake!" });
            hymns.Add(new SelectListItem() { Text = "18. The Voice of God Again is Heard", Value = "18. The Voice of God Again is Heard" });
            hymns.Add(new SelectListItem() { Text = "19. We Thank Thee, O God, for a Prophet", Value = "19. We Thank Thee, O God, for a Prophet" });
            hymns.Add(new SelectListItem() { Text = "20. God of Power, God of Right", Value = "20. God of Power, God of Right" });
            hymns.Add(new SelectListItem() { Text = "21. Come, Listen to a Prophet's Voice", Value = "21. Come, Listen to a Prophet's Voice" });
            hymns.Add(new SelectListItem() { Text = "22. We Listen to a Prophet's Voice", Value = "22. We Listen to a Prophet's Voice" });
            hymns.Add(new SelectListItem() { Text = "23. We Ever Pray for Thee", Value = "23. We Ever Pray for Thee" });
            hymns.Add(new SelectListItem() { Text = "24. God Bless Our Prophet Dear", Value = "24. God Bless Our Prophet Dear" });
            hymns.Add(new SelectListItem() { Text = "25. Now We'll Sing With One Accord", Value = "25. Now We'll Sing With One Accord" });
            hymns.Add(new SelectListItem() { Text = "26. Joseph Smith's First Prayer", Value = "26. Joseph Smith's First Prayer" });
            hymns.Add(new SelectListItem() { Text = "27. Praise to the Man", Value = "27. Praise to the Man" });
            hymns.Add(new SelectListItem() { Text = "28. Saints, Behold How Great Jehovah", Value = "28. Saints, Behold How Great Jehovah" });
            hymns.Add(new SelectListItem() { Text = "29. A Poor Wayfaring Man of Grief", Value = "29. A Poor Wayfaring Man of Grief" });
            hymns.Add(new SelectListItem() { Text = "30. Come, Come, Ye Saints", Value = "30. Come, Come, Ye Saints" });
            hymns.Add(new SelectListItem() { Text = "31. O God, Our Help in Ages Past", Value = "31. O God, Our Help in Ages Past" });
            hymns.Add(new SelectListItem() { Text = "32. The Happy Day at Last Has Come", Value = "32. The Happy Day at Last Has Come" });
            hymns.Add(new SelectListItem() { Text = "33. Our Mountain Home So Dear", Value = "33. Our Mountain Home So Dear" });
            hymns.Add(new SelectListItem() { Text = "34. O Ye Mountains High", Value = "34. O Ye Mountains High" });
            hymns.Add(new SelectListItem() { Text = "35. For the Strength of the Hills", Value = "35. For the Strength of the Hills" });
            hymns.Add(new SelectListItem() { Text = "36. They, the Builders of the Nation", Value = "36. They, the Builders of the Nation" });
            hymns.Add(new SelectListItem() { Text = "37. The Wintry Day, Descending to Its Close", Value = "37. The Wintry Day, Descending to Its Close" });
            hymns.Add(new SelectListItem() { Text = "38. Come, All Ye Saints of Zion", Value = "38. Come, All Ye Saints of Zion" });
            hymns.Add(new SelectListItem() { Text = "39. O Saints of Zion", Value = "39. O Saints of Zion" });
            hymns.Add(new SelectListItem() { Text = "40. Arise, O Glorious Zion", Value = "40. Arise, O Glorious Zion" });
            hymns.Add(new SelectListItem() { Text = "41. Let Zion in Her Beauty Rise", Value = "41. Let Zion in Her Beauty Rise" });
            hymns.Add(new SelectListItem() { Text = "42. Hail to the Brightness of Zion's glad Morning!", Value = "42. Hail to the Brightness of Zion's glad Morning!" });
            hymns.Add(new SelectListItem() { Text = "43. Zion Stands with Hills Surrounded", Value = "43. Zion Stands with Hills Surrounded" });
            hymns.Add(new SelectListItem() { Text = "44. Beautiful Zion, Built Above", Value = "44. Beautiful Zion, Built Above" });
            hymns.Add(new SelectListItem() { Text = "45. Lead Me Into Life Eternal", Value = "45. Lead Me Into Life Eternal" });
            hymns.Add(new SelectListItem() { Text = "46. Glorious Things of Thee Are Spoken", Value = "46. Glorious Things of Thee Are Spoken" });
            hymns.Add(new SelectListItem() { Text = "47. We Will Sing of Zion", Value = "47. We Will Sing of Zion" });
            hymns.Add(new SelectListItem() { Text = "48. Glorious Things Are Sung of Zion", Value = "48. Glorious Things Are Sung of Zion" });
            hymns.Add(new SelectListItem() { Text = "49. Adam-ondi-Ahman", Value = "49. Adam-ondi-Ahman" });
            hymns.Add(new SelectListItem() { Text = "50. Come, Though Glorious Day of Promise", Value = "50. Come, Though Glorious Day of Promise" });
            hymns.Add(new SelectListItem() { Text = "51. Sons of Michael, he Approaches", Value = "51. Sons of Michael, he Approaches" });
            hymns.Add(new SelectListItem() { Text = "52. The Day Dawn is Breaking", Value = "52. The Day Dawn is Breaking" });
            hymns.Add(new SelectListItem() { Text = "53. Let Earth's Inhabitants Rejoice", Value = "53. Let Earth's Inhabitants Rejoice" });
            hymns.Add(new SelectListItem() { Text = "54. Behold, the Mountain of the Lord", Value = "54. Behold, the Mountain of the Lord" });
            hymns.Add(new SelectListItem() { Text = "55. Lo, the Mighty God Appearing!", Value = "55. Lo, the Mighty God Appearing!" });
            hymns.Add(new SelectListItem() { Text = "56. Softly Beams the Sacred Dawning", Value = "56. Softly Beams the Sacred Dawning" });
            hymns.Add(new SelectListItem() { Text = "57. We're Not Ashamed to Own Our Lord", Value = "57. We're Not Ashamed to Own Our Lord" });
            hymns.Add(new SelectListItem() { Text = "58. Come, Ye Children of the Lord", Value = "58. Come, Ye Children of the Lord" });
            hymns.Add(new SelectListItem() { Text = "59. Come, O Thou King of Kings", Value = "59. Come, O Thou King of Kings" });
            hymns.Add(new SelectListItem() { Text = "60. Battle Hymn of the Republic", Value = "60. Battle Hymn of the Republic" });
            hymns.Add(new SelectListItem() { Text = "61. Raise Your Voice to the Lord", Value = "61. Raise Your Voice to the Lord" });
            hymns.Add(new SelectListItem() { Text = "62. All creatures of Our God and King", Value = "62. All creatures of Our God and King" });
            hymns.Add(new SelectListItem() { Text = "63. Great King of Heaven", Value = "63. Great King of Heaven" });
            hymns.Add(new SelectListItem() { Text = "64. On This Day of Joy and Gladness", Value = "64. On This Day of Joy and Gladness" });
            hymns.Add(new SelectListItem() { Text = "65. Come, All ye Saints Who Dwell on Earth", Value = "65. Come, All ye Saints Who Dwell on Earth" });
            hymns.Add(new SelectListItem() { Text = "66. Rejoice, the Lord Is King!", Value = "66. Rejoice, the Lord Is King!" });
            hymns.Add(new SelectListItem() { Text = "67. Glory to God on High", Value = "67. Glory to God on High" });
            hymns.Add(new SelectListItem() { Text = "68. A Mighty Fortress Is Our God", Value = "68. A Mighty Fortress Is Our God" });
            hymns.Add(new SelectListItem() { Text = "69. All Glory, Laud, and Honor", Value = "69. All Glory, Laud, and Honor" });
            hymns.Add(new SelectListItem() { Text = "70. Sing Praise to Him", Value = "70. Sing Praise to Him" });
            hymns.Add(new SelectListItem() { Text = "71. With Songs of Praise", Value = "71. With Songs of Praise" });
            hymns.Add(new SelectListItem() { Text = "72. Praise to the Lord, the Almighty", Value = "72. Praise to the Lord, the Almighty" });
            hymns.Add(new SelectListItem() { Text = "73. Praise the Lord with Heart and Voice", Value = "73. Praise the Lord with Heart and Voice" });
            hymns.Add(new SelectListItem() { Text = "74. Praise Ye the Lord", Value = "74. Praise Ye the Lord" });
            hymns.Add(new SelectListItem() { Text = "75. In Hymns of Praise", Value = "75. In Hymns of Praise" });
            hymns.Add(new SelectListItem() { Text = "76. God of Our Fathers, We Come unto Thee", Value = "76. God of Our Fathers, We Come unto Thee" });
            hymns.Add(new SelectListItem() { Text = "77. Great Is the Lord", Value = "77. Great Is the Lord" });
            hymns.Add(new SelectListItem() { Text = "78. God of Our Fathers, Whose Almighty Hand", Value = "78. God of Our Fathers, Whose Almighty Hand" });
            hymns.Add(new SelectListItem() { Text = "79. With All the Power of Heart and Tongue", Value = "79. With All the Power of Heart and Tongue" });
            hymns.Add(new SelectListItem() { Text = "80. God of Our Fathers, Known of Old", Value = "80. God of Our Fathers, Known of Old" });
            hymns.Add(new SelectListItem() { Text = "81. Press Forward, Saints", Value = "81. Press Forward, Saints" });
            hymns.Add(new SelectListItem() { Text = "82. For All the Saints", Value = "82. For All the Saints" });
            hymns.Add(new SelectListItem() { Text = "83. Guide Us, O Thou Great Jehovah", Value = "83. Guide Us, O Thou Great Jehovah" });
            hymns.Add(new SelectListItem() { Text = "84. Faith of Our Fathers", Value = "84. Faith of Our Fathers" });
            hymns.Add(new SelectListItem() { Text = "85. How Firm a Foundation", Value = "85. How Firm a Foundation" });
            hymns.Add(new SelectListItem() { Text = "86. How Great Thou Art", Value = "86. How Great Thou Art" });
            hymns.Add(new SelectListItem() { Text = "87. God Is Love", Value = "87. God Is Love" });
            hymns.Add(new SelectListItem() { Text = "88. Great God, Attend While Zion Sings", Value = "88. Great God, Attend While Zion Sings" });
            hymns.Add(new SelectListItem() { Text = "89. The Lord Is My Light", Value = "89. The Lord Is My Light" });
            hymns.Add(new SelectListItem() { Text = "90. from All That Dwell below the Skies", Value = "90. from All That Dwell below the Skies" });
            hymns.Add(new SelectListItem() { Text = "91. Father, Thy Children to Thee Now Raise", Value = "91. Father, Thy Children to Thee Now Raise" });
            hymns.Add(new SelectListItem() { Text = "92. For the Beauty of the Earth", Value = "92. For the Beauty of the Earth" });
            hymns.Add(new SelectListItem() { Text = "93. Prayer of Thanksgiving", Value = "93. Prayer of Thanksgiving" });
            hymns.Add(new SelectListItem() { Text = "94. Come, Ye Thankful People", Value = "94. Come, Ye Thankful People" });
            hymns.Add(new SelectListItem() { Text = "95. Now Thank We All Our God", Value = "95. Now Thank We All Our God" });
            hymns.Add(new SelectListItem() { Text = "96. Dearest Children, God is Near You", Value = "96. Dearest Children, God is Near You" });
            hymns.Add(new SelectListItem() { Text = "97. Lead, Kindly Light", Value = "97. Lead, Kindly Light" });
            hymns.Add(new SelectListItem() { Text = "98. I Need Thee Every Hour", Value = "98. I Need Thee Every Hour" });
            hymns.Add(new SelectListItem() { Text = "99. Nearer, Dear Savior, to Thee", Value = "99. Nearer, Dear Savior, to Thee" });
            hymns.Add(new SelectListItem() { Text = "100. Nearer My God to Thee", Value = "100. Nearer My God to Thee" });
            hymns.Add(new SelectListItem() { Text = "101. Guide Me to Thee", Value = "101. Guide Me to Thee" });
            hymns.Add(new SelectListItem() { Text = "102. Jesus, Lover of My Soul", Value = "102. Jesus, Lover of My Soul" });
            hymns.Add(new SelectListItem() { Text = "103. Precious Savior, Dear Redeemer", Value = "103. Precious Savior, Dear Redeemer" });
            hymns.Add(new SelectListItem() { Text = "104. Jesus, Savior, Pilot Me", Value = "104. Jesus, Savior, Pilot Me" });
            hymns.Add(new SelectListItem() { Text = "105. Master, the Tempest Is Raging", Value = "105. Master, the Tempest Is Raging" });
            hymns.Add(new SelectListItem() { Text = "106. God Speed the Right", Value = "106. God Speed the Right" });
            hymns.Add(new SelectListItem() { Text = "107. Lord, Accept Our True Devotion", Value = "107. Lord, Accept Our True Devotion" });
            hymns.Add(new SelectListItem() { Text = "108. The Lord Is My Shepherd", Value = "108. The Lord Is My Shepherd" });
            hymns.Add(new SelectListItem() { Text = "109. The Lord My pasture Will Prepare", Value = "109. The Lord My pasture Will Prepare" });
            hymns.Add(new SelectListItem() { Text = "110. Cast Thy Burden Upon the Lord", Value = "110. Cast Thy Burden Upon the Lord" });
            hymns.Add(new SelectListItem() { Text = "111. Rock of Ages", Value = "111. Rock of Ages" });
            hymns.Add(new SelectListItem() { Text = "112. Savior, Redeemer of My Soul", Value = "112. Savior, Redeemer of My Soul" });
            hymns.Add(new SelectListItem() { Text = "113. Our Savior's Love", Value = "113. Our Savior's Love" });
            hymns.Add(new SelectListItem() { Text = "114. Come Unto Him", Value = "114. Come Unto Him" });
            hymns.Add(new SelectListItem() { Text = "115. Come, Ye Disconsolate", Value = "115. Come, Ye Disconsolate" });
            hymns.Add(new SelectListItem() { Text = "116. Come, Follow Me", Value = "116. Come, Follow Me" });
            hymns.Add(new SelectListItem() { Text = "117. Come Unto Jesus", Value = "117. Come Unto Jesus" });
            hymns.Add(new SelectListItem() { Text = "118. Ye Simple Souls Who Stray", Value = "118. Ye Simple Souls Who Stray" });
            hymns.Add(new SelectListItem() { Text = "119. Come, We That Love the Lord", Value = "119. Come, We That Love the Lord" });
            hymns.Add(new SelectListItem() { Text = "120. Lean on My Ample Arm", Value = "120. Lean on My Ample Arm" });
            hymns.Add(new SelectListItem() { Text = "121. I'm a Pilgrim, I'm a Stranger", Value = "121. I'm a Pilgrim, I'm a Stranger" });
            hymns.Add(new SelectListItem() { Text = "122. Though Deepening Trials", Value = "122. Though Deepening Trials" });
            hymns.Add(new SelectListItem() { Text = "123. Oh, May My Soul Commune With Thee", Value = "123. Oh, May My Soul Commune With Thee" });
            hymns.Add(new SelectListItem() { Text = "124. Be Still, My Soul", Value = "124. Be Still, My Soul" });
            hymns.Add(new SelectListItem() { Text = "125. How Gentle God's Commands", Value = "125. How Gentle God's Commands" });
            hymns.Add(new SelectListItem() { Text = "126. How Long, O Lord Most Holy and True", Value = "126. How Long, O Lord Most Holy and True" });
            hymns.Add(new SelectListItem() { Text = "127. Does the Journey Seem Long?", Value = "127. Does the Journey Seem Long?" });
            hymns.Add(new SelectListItem() { Text = "128. When Faith Endures", Value = "128. When Faith Endures" });
            hymns.Add(new SelectListItem() { Text = "129. Where Can I Turn for Peace?", Value = "129. Where Can I Turn for Peace?" });
            hymns.Add(new SelectListItem() { Text = "130. Be Thu Humble", Value = "130. Be Thu Humble" });
            hymns.Add(new SelectListItem() { Text = "131. More Holiness Give Me", Value = "131. More Holiness Give Me" });
            hymns.Add(new SelectListItem() { Text = "132. God Is in His Holy Temple", Value = "132. God Is in His Holy Temple" });
            hymns.Add(new SelectListItem() { Text = "133. Father in Heaven", Value = "133. Father in Heaven" });
            hymns.Add(new SelectListItem() { Text = "134. I Believe in Christ", Value = "134. I Believe in Christ" });
            hymns.Add(new SelectListItem() { Text = "135. My Redeemer Lives", Value = "135. My Redeemer Lives" });
            hymns.Add(new SelectListItem() { Text = "136. I Know That My Redeemer Lives", Value = "136. I Know That My Redeemer Lives" });
            hymns.Add(new SelectListItem() { Text = "137. Testimony", Value = "137. Testimony" });
            hymns.Add(new SelectListItem() { Text = "138. Bless Our Fast, We Pray", Value = "138. Bless Our Fast, We Pray" });
            hymns.Add(new SelectListItem() { Text = "139. In Fasting We Approach Thee", Value = "139. In Fasting We Approach Thee" });
            hymns.Add(new SelectListItem() { Text = "140. Did You Think to Pray?", Value = "140. Did You Think to Pray?" });
            hymns.Add(new SelectListItem() { Text = "141. Jesus, the Very Thought of Thee", Value = "141. Jesus, the Very Thought of Thee" });
            hymns.Add(new SelectListItem() { Text = "142. Sweet Hour of Prayer", Value = "142. Sweet Hour of Prayer" });
            hymns.Add(new SelectListItem() { Text = "143. Let the Holy Spirit Guide", Value = "143. Let the Holy Spirit Guide" });
            hymns.Add(new SelectListItem() { Text = "144. Secret Prayer", Value = "144. Secret Prayer" });
            hymns.Add(new SelectListItem() { Text = "145. Prayer Is the Soul's Sincere Desire", Value = "145. Prayer Is the Soul's Sincere Desire" });
            hymns.Add(new SelectListItem() { Text = "146. Gently Raise the Sacred Strain", Value = "146. Gently Raise the Sacred Strain" });
            hymns.Add(new SelectListItem() { Text = "147. Sweet Is the Work", Value = "147. Sweet Is the Work" });
            hymns.Add(new SelectListItem() { Text = "148. Sabbath Day", Value = "148. Sabbath Day" });
            hymns.Add(new SelectListItem() { Text = "149. As the Dew from Heaven Distilling", Value = "149. As the Dew from Heaven Distilling" });
            hymns.Add(new SelectListItem() { Text = "150. O Thou Kind and Gracious Father", Value = "150. O Thou Kind and Gracious Father" });
            hymns.Add(new SelectListItem() { Text = "151. We Meet, Dear Lord", Value = "151. We Meet, Dear Lord" });
            hymns.Add(new SelectListItem() { Text = "152. God Be with You Till We Meet Again", Value = "152. God Be with You Till We Meet Again" });
            hymns.Add(new SelectListItem() { Text = "153. Lord, We Ask Thee Ere We Part", Value = "153. Lord, We Ask Thee Ere We Part" });
            hymns.Add(new SelectListItem() { Text = "154. Father, This Hour Has Been One of Joy", Value = "154. Father, This Hour Has Been One of Joy" });
            hymns.Add(new SelectListItem() { Text = "155. We Have Partaken of Thy Love", Value = "155. We Have Partaken of Thy Love" });
            hymns.Add(new SelectListItem() { Text = "156. Sing We Now at Parting", Value = "156. Sing We Now at Parting" });
            hymns.Add(new SelectListItem() { Text = "157. Thy Spirit, Lord, Has Stirred Our Souls", Value = "157. Thy Spirit, Lord, Has Stirred Our Souls" });
            hymns.Add(new SelectListItem() { Text = "158. Before Thee, Lord, I Bow My Head", Value = "158. Before Thee, Lord, I Bow My Head" });
            hymns.Add(new SelectListItem() { Text = "159. Now the Day Is Over", Value = "159. Now the Day Is Over" });
            hymns.Add(new SelectListItem() { Text = "160. Softly Now the Light of Day", Value = "160. Softly Now the Light of Day" });
            hymns.Add(new SelectListItem() { Text = "161. The Lord Be with Us", Value = "161. The Lord Be with Us" });
            hymns.Add(new SelectListItem() { Text = "162. Lord, We Come Before Thee Now", Value = "162. Lord, We Come Before Thee Now" });
            hymns.Add(new SelectListItem() { Text = "163. Lord, Dismiss Us with Thy Blessing", Value = "163. Lord, Dismiss Us with Thy Blessing" });
            hymns.Add(new SelectListItem() { Text = "164. Great God, to Thee My Evening Song", Value = "164. Great God, to Thee My Evening Song" });
            hymns.Add(new SelectListItem() { Text = "165. Abide With me", Value = "165. Abide With me" });
            hymns.Add(new SelectListItem() { Text = "166. Abide with Me!", Value = "166. Abide with Me!" });
            hymns.Add(new SelectListItem() { Text = "167. Come, Let Us Sing an Evening Hymn", Value = "167. Come, Let Us Sing an Evening Hymn" });
            hymns.Add(new SelectListItem() { Text = "168. As the Shadows Fall", Value = "168. As the Shadows Fall" });
            hymns.Add(new SelectListItem() { Text = "169. As Now We Take the Sacrament", Value = "169. As Now We Take the Sacrament" });
            hymns.Add(new SelectListItem() { Text = "170. God, Our Father, Hear Us Pray", Value = "170. God, Our Father, Hear Us Pray" });
            hymns.Add(new SelectListItem() { Text = "171. With Humble Heart", Value = "171. With Humble Heart" });
            hymns.Add(new SelectListItem() { Text = "172. In Humility, Our Savior", Value = "172. In Humility, Our Savior" });
            hymns.Add(new SelectListItem() { Text = "173. While of These Emblems We Partake", Value = "173. While of These Emblems We Partake" });
            hymns.Add(new SelectListItem() { Text = "174. While of These Emblems We Partake", Value = "174. While of These Emblems We Partake" });
            hymns.Add(new SelectListItem() { Text = "175. O God, the Eternal Father", Value = "175. O God, the Eternal Father" });
            hymns.Add(new SelectListItem() { Text = "176. 'Tis Sweet to Sing the Matchless Love", Value = "176. 'Tis Sweet to Sing the Matchless Love" });
            hymns.Add(new SelectListItem() { Text = "177. 'Tis Sweet to Sing the Matchless Love", Value = "177. 'Tis Sweet to Sing the Matchless Love" });
            hymns.Add(new SelectListItem() { Text = "178. O Lord of Hosts", Value = "178. O Lord of Hosts" });
            hymns.Add(new SelectListItem() { Text = "179. Again, Our Dear Redeeming Lord", Value = "179. Again, Our Dear Redeeming Lord" });
            hymns.Add(new SelectListItem() { Text = "180. Father in Heaven, We Do Believe", Value = "180. Father in Heaven, We Do Believe" });
            hymns.Add(new SelectListItem() { Text = "181. Jesus of Nazareth, Savior and King", Value = "181. Jesus of Nazareth, Savior and King" });
            hymns.Add(new SelectListItem() { Text = "182. We'll Sing All Hail to Jesus' Name", Value = "182. We'll Sing All Hail to Jesus' Name" });
            hymns.Add(new SelectListItem() { Text = "183. In Remembrance of Thy Suffering", Value = "183. In Remembrance of Thy Suffering" });
            hymns.Add(new SelectListItem() { Text = "184. Upon the Cross of Calvary", Value = "184. Upon the Cross of Calvary" });
            hymns.Add(new SelectListItem() { Text = "185. Reverently and Meekly Now", Value = "185. Reverently and Meekly Now" });
            hymns.Add(new SelectListItem() { Text = "186. Again We Meet Around the Board", Value = "186. Again We Meet Around the Board" });
            hymns.Add(new SelectListItem() { Text = "187. God Loved Us, So He Sent His Son", Value = "187. God Loved Us, So He Sent His Son" });
            hymns.Add(new SelectListItem() { Text = "188. Thy Will, O Lord, Be Done", Value = "188. Thy Will, O Lord, Be Done" });
            hymns.Add(new SelectListItem() { Text = "189. O Thou, Before the World Began", Value = "189. O Thou, Before the World Began" });
            hymns.Add(new SelectListItem() { Text = "190. In Memory of the Crucified", Value = "190. In Memory of the Crucified" });
            hymns.Add(new SelectListItem() { Text = "191. Behold the Great Redeemer Die", Value = "191. Behold the Great Redeemer Die" });
            hymns.Add(new SelectListItem() { Text = "192. He Died! The Great Redeemer Died", Value = "192. He Died! The Great Redeemer Died" });
            hymns.Add(new SelectListItem() { Text = "193. I Stand All Amazed", Value = "193. I Stand All Amazed" });
            hymns.Add(new SelectListItem() { Text = "194. There is a Green Hill Far Away", Value = "194. There is a Green Hill Far Away" });
            hymns.Add(new SelectListItem() { Text = "195. How Great the Wisdom and the Love", Value = "195. How Great the Wisdom and the Love" });
            hymns.Add(new SelectListItem() { Text = "196. Jesus, Once of Humble Birth", Value = "196. Jesus, Once of Humble Birth" });
            hymns.Add(new SelectListItem() { Text = "197. O Savior, Thou Who Wearest a Crown", Value = "197. O Savior, Thou Who Wearest a Crown" });
            hymns.Add(new SelectListItem() { Text = "198. That Easter Morn", Value = "198. That Easter Morn" });
            hymns.Add(new SelectListItem() { Text = "199. He is Risen!", Value = "199. He is Risen!" });
            hymns.Add(new SelectListItem() { Text = "200. Christ the Lord Is Risen Today", Value = "200. Christ the Lord Is Risen Today" });
            hymns.Add(new SelectListItem() { Text = "201. Joy to the World", Value = "201. Joy to the World" });
            hymns.Add(new SelectListItem() { Text = "202. Oh, Come, All Ye Faithful", Value = "202. Oh, Come, All Ye Faithful" });
            hymns.Add(new SelectListItem() { Text = "203. Angels We Have Heard on High", Value = "203. Angels We Have Heard on High" });
            hymns.Add(new SelectListItem() { Text = "204. Silent Night (song)|Silent Night", Value = "204. Silent Night (song)|Silent Night" });
            hymns.Add(new SelectListItem() { Text = "205. Once In Royal David's City|Once in Royal David's City", Value = "205. Once In Royal David's City|Once in Royal David's City" });
            hymns.Add(new SelectListItem() { Text = "206. Away in a Manger", Value = "206. Away in a Manger" });
            hymns.Add(new SelectListItem() { Text = "207. It Came Upon the Midnight Clear", Value = "207. It Came Upon the Midnight Clear" });
            hymns.Add(new SelectListItem() { Text = "208. O Little Town of Bethlehem", Value = "208. O Little Town of Bethlehem" });
            hymns.Add(new SelectListItem() { Text = "209. Hark! The Herald Angels Sing|Hark! the Herald Angels Sing", Value = "209. Hark! The Herald Angels Sing|Hark! the Herald Angels Sing" });
            hymns.Add(new SelectListItem() { Text = "210. With Wondering Awe", Value = "210. With Wondering Awe" });
            hymns.Add(new SelectListItem() { Text = "211. While Shepherds Watched Their Flocks", Value = "211. While Shepherds Watched Their Flocks" });
            hymns.Add(new SelectListItem() { Text = "212. Far, Far Away on Judea's Plains", Value = "212. Far, Far Away on Judea's Plains" });
            hymns.Add(new SelectListItem() { Text = "213. The First Nowell/The First Noel", Value = "213. The First Nowell/The First Noel" });
            hymns.Add(new SelectListItem() { Text = "214. I Heard the Bells on Christmas Day", Value = "214. I Heard the Bells on Christmas Day" });
            hymns.Add(new SelectListItem() { Text = "215. Ring Out, Wild Bells", Value = "215. Ring Out, Wild Bells" });
            hymns.Add(new SelectListItem() { Text = "216. We Are Sowing", Value = "216. We Are Sowing" });
            hymns.Add(new SelectListItem() { Text = "217. Come, Let Us Anew", Value = "217. Come, Let Us Anew" });
            hymns.Add(new SelectListItem() { Text = "218. We Give Thee But Thine Own", Value = "218. We Give Thee But Thine Own" });
            hymns.Add(new SelectListItem() { Text = "219. Because I Have Been Given Much", Value = "219. Because I Have Been Given Much" });
            hymns.Add(new SelectListItem() { Text = "220. Lord, I Would Follow Thee", Value = "220. Lord, I Would Follow Thee" });
            hymns.Add(new SelectListItem() { Text = "221. Dear to the Heart of the Shepherd", Value = "221. Dear to the Heart of the Shepherd" });
            hymns.Add(new SelectListItem() { Text = "222. Hear Thou Our Hymn, O Lord", Value = "222. Hear Thou Our Hymn, O Lord" });
            hymns.Add(new SelectListItem() { Text = "223. Have I Done Any Good?", Value = "223. Have I Done Any Good?" });
            hymns.Add(new SelectListItem() { Text = "224. I Have Work Enough to Do", Value = "224. I Have Work Enough to Do" });
            hymns.Add(new SelectListItem() { Text = "225. We Are Marching On to Glory", Value = "225. We Are Marching On to Glory" });
            hymns.Add(new SelectListItem() { Text = "226. Improve the Shining Moments", Value = "226. Improve the Shining Moments" });
            hymns.Add(new SelectListItem() { Text = "227. There Is Sunshine in My Soul Today", Value = "227. There Is Sunshine in My Soul Today" });
            hymns.Add(new SelectListItem() { Text = "228. You Can Make the Pathway Bright", Value = "228. You Can Make the Pathway Bright" });
            hymns.Add(new SelectListItem() { Text = "229. Today, While the Sun Shines", Value = "229. Today, While the Sun Shines" });
            hymns.Add(new SelectListItem() { Text = "230. Scatter Sunshine", Value = "230. Scatter Sunshine" });
            hymns.Add(new SelectListItem() { Text = "231. Father, Cheer Our Souls Tonight", Value = "231. Father, Cheer Our Souls Tonight" });
            hymns.Add(new SelectListItem() { Text = "232. Let Us Oft Speak Kind Words", Value = "232. Let Us Oft Speak Kind Words" });
            hymns.Add(new SelectListItem() { Text = "233. Nay, Speak No Ill", Value = "233. Nay, Speak No Ill" });
            hymns.Add(new SelectListItem() { Text = "234. Jesus, Mighty King in Zion", Value = "234. Jesus, Mighty King in Zion" });
            hymns.Add(new SelectListItem() { Text = "235. Should You Feel Inclined to Censure", Value = "235. Should You Feel Inclined to Censure" });
            hymns.Add(new SelectListItem() { Text = "236. Lord, Accept into Thy Kingdom", Value = "236. Lord, Accept into Thy Kingdom" });
            hymns.Add(new SelectListItem() { Text = "237. Do What Is Right", Value = "237. Do What Is Right" });
            hymns.Add(new SelectListItem() { Text = "238. Behold Thy Sons and Daughters, Lord", Value = "238. Behold Thy Sons and Daughters, Lord" });
            hymns.Add(new SelectListItem() { Text = "239. Choose the Right", Value = "239. Choose the Right" });
            hymns.Add(new SelectListItem() { Text = "240. Know This, That Every Soul Is Free", Value = "240. Know This, That Every Soul Is Free" });
            hymns.Add(new SelectListItem() { Text = "241. Count Your Blessings", Value = "241. Count Your Blessings" });
            hymns.Add(new SelectListItem() { Text = "242. Praise God, from Whom All Blessings Flow", Value = "242. Praise God, from Whom All Blessings Flow" });
            hymns.Add(new SelectListItem() { Text = "243. Let Us All Press On", Value = "243. Let Us All Press On" });
            hymns.Add(new SelectListItem() { Text = "244. Come Along, Come Along", Value = "244. Come Along, Come Along" });
            hymns.Add(new SelectListItem() { Text = "245. This House We Dedicate to Thee", Value = "245. This House We Dedicate to Thee" });
            hymns.Add(new SelectListItem() { Text = "246. Onward, Christian Soldiers", Value = "246. Onward, Christian Soldiers" });
            hymns.Add(new SelectListItem() { Text = "247. We Love Thy House, O God", Value = "247. We Love Thy House, O God" });
            hymns.Add(new SelectListItem() { Text = "248. Up, Awake Ye Defenders of Zion", Value = "248. Up, Awake Ye Defenders of Zion" });
            hymns.Add(new SelectListItem() { Text = "249. Called to Serve", Value = "249. Called to Serve" });
            hymns.Add(new SelectListItem() { Text = "250. We Are All Enlisted", Value = "250. We Are All Enlisted" });
            hymns.Add(new SelectListItem() { Text = "251. Behold! A Royal Army", Value = "251. Behold! A Royal Army" });
            hymns.Add(new SelectListItem() { Text = "252. Put Your Shoulder to the Wheel", Value = "252. Put Your Shoulder to the Wheel" });
            hymns.Add(new SelectListItem() { Text = "253. Like Ten Thousand Legions Marching", Value = "253. Like Ten Thousand Legions Marching" });
            hymns.Add(new SelectListItem() { Text = "254. True to the Faith", Value = "254. True to the Faith" });
            hymns.Add(new SelectListItem() { Text = "255. Carry On", Value = "255. Carry On" });
            hymns.Add(new SelectListItem() { Text = "256. As Zion's Youth In Latter Days", Value = "256. As Zion's Youth In Latter Days" });
            hymns.Add(new SelectListItem() { Text = "257. Rejoice! A Glorious Sound Is Heard", Value = "257. Rejoice! A Glorious Sound Is Heard" });
            hymns.Add(new SelectListItem() { Text = "258. O Thou Rock of Our Salvation", Value = "258. O Thou Rock of Our Salvation" });
            hymns.Add(new SelectListItem() { Text = "259. Hope of Israel", Value = "259. Hope of Israel" });
            hymns.Add(new SelectListItem() { Text = "260. Who's on the Lord's Side?", Value = "260. Who's on the Lord's Side?" });
            hymns.Add(new SelectListItem() { Text = "261. Thy Servants Are Prepared", Value = "261. Thy Servants Are Prepared" });
            hymns.Add(new SelectListItem() { Text = "262. Go, Ye Messengers of Glory", Value = "262. Go, Ye Messengers of Glory" });
            hymns.Add(new SelectListItem() { Text = "263. Go Forth with Faith", Value = "263. Go Forth with Faith" });
            hymns.Add(new SelectListItem() { Text = "264. Hark, All Ye Nations!", Value = "264. Hark, All Ye Nations!" });
            hymns.Add(new SelectListItem() { Text = "265. Arise, O God, and Shine", Value = "265. Arise, O God, and Shine" });
            hymns.Add(new SelectListItem() { Text = "266. The Time Is Far Spent", Value = "266. The Time Is Far Spent" });
            hymns.Add(new SelectListItem() { Text = "267. How Wondrous and Great", Value = "267. How Wondrous and Great" });
            hymns.Add(new SelectListItem() { Text = "268. Come, All Whose Souls are Lighted", Value = "268. Come, All Whose Souls are Lighted" });
            hymns.Add(new SelectListItem() { Text = "269. Jehovah, Lord of Heaven and Earth", Value = "269. Jehovah, Lord of Heaven and Earth" });
            hymns.Add(new SelectListItem() { Text = "270. I'll Go Where You Want Me to Go", Value = "270. I'll Go Where You Want Me to Go" });
            hymns.Add(new SelectListItem() { Text = "271. Oh, Holy Words of Truth and Love", Value = "271. Oh, Holy Words of Truth and Love" });
            hymns.Add(new SelectListItem() { Text = "272. Oh Say, What Is Truth?", Value = "272. Oh Say, What Is Truth?" });
            hymns.Add(new SelectListItem() { Text = "273. Truth Reflects Upon Our Senses", Value = "273. Truth Reflects Upon Our Senses" });
            hymns.Add(new SelectListItem() { Text = "274. The Iron Rod", Value = "274. The Iron Rod" });
            hymns.Add(new SelectListItem() { Text = "275. Men Are That They Might Have Joy", Value = "275. Men Are That They Might Have Joy" });
            hymns.Add(new SelectListItem() { Text = "276. Come Away to Sunday School", Value = "276. Come Away to Sunday School" });
            hymns.Add(new SelectListItem() { Text = "277. As I Search the Holy Scriptures", Value = "277. As I Search the Holy Scriptures" });
            hymns.Add(new SelectListItem() { Text = "278. Thanks for the Sabbath School", Value = "278. Thanks for the Sabbath School" });
            hymns.Add(new SelectListItem() { Text = "279. The Holy Word", Value = "279. The Holy Word" });
            hymns.Add(new SelectListItem() { Text = "280. Welcome, Welcome, Sabbath Morning", Value = "280. Welcome, Welcome, Sabbath Morning" });
            hymns.Add(new SelectListItem() { Text = "281. Help Me Teach with Inspiration", Value = "281. Help Me Teach with Inspiration" });
            hymns.Add(new SelectListItem() { Text = "282. We Meet Again in Sabbath School", Value = "282. We Meet Again in Sabbath School" });
            hymns.Add(new SelectListItem() { Text = "283. The Glorious Gospel Light Has Shone", Value = "283. The Glorious Gospel Light Has Shone" });
            hymns.Add(new SelectListItem() { Text = "284. If You Could Hie to Kolob", Value = "284. If You Could Hie to Kolob" });
            hymns.Add(new SelectListItem() { Text = "285. God Moves in a Mysterious Way", Value = "285. God Moves in a Mysterious Way" });
            hymns.Add(new SelectListItem() { Text = "286. Oh, What Songs of the Heart", Value = "286. Oh, What Songs of the Heart" });
            hymns.Add(new SelectListItem() { Text = "287. Rise, Ye Saints, and Temples Enter", Value = "287. Rise, Ye Saints, and Temples Enter" });
            hymns.Add(new SelectListItem() { Text = "288. How Beautiful Thy Temples, Lord", Value = "288. How Beautiful Thy Temples, Lord" });
            hymns.Add(new SelectListItem() { Text = "289. Holy Temples on Mount Zion", Value = "289. Holy Temples on Mount Zion" });
            hymns.Add(new SelectListItem() { Text = "290. Rejoice, Ye Saints of Latter Days", Value = "290. Rejoice, Ye Saints of Latter Days" });
            hymns.Add(new SelectListItem() { Text = "291. Turn Your Hearts", Value = "291. Turn Your Hearts" });
            hymns.Add(new SelectListItem() { Text = "292. O My Father", Value = "292. O My Father" });
            hymns.Add(new SelectListItem() { Text = "293. Each Life That Touches Ours for Good", Value = "293. Each Life That Touches Ours for Good" });
            hymns.Add(new SelectListItem() { Text = "294. Love at Home", Value = "294. Love at Home" });
            hymns.Add(new SelectListItem() { Text = "295. O Love That Glorifies the Son", Value = "295. O Love That Glorifies the Son" });
            hymns.Add(new SelectListItem() { Text = "296. Our Father, by Whose Name", Value = "296. Our Father, by Whose Name" });
            hymns.Add(new SelectListItem() { Text = "297. From Homes of Saints Glad Songs Arise", Value = "297. From Homes of Saints Glad Songs Arise" });
            hymns.Add(new SelectListItem() { Text = "298. Home Can Be a Heaven on Earth", Value = "298. Home Can Be a Heaven on Earth" });
            hymns.Add(new SelectListItem() { Text = "299. Children of Our Heavenly Father", Value = "299. Children of Our Heavenly Father" });
            hymns.Add(new SelectListItem() { Text = "300. Families Can Be Together Forever", Value = "300. Families Can Be Together Forever" });
            hymns.Add(new SelectListItem() { Text = "301. I Am a Child of God", Value = "301. I Am a Child of God" });
            hymns.Add(new SelectListItem() { Text = "302. I Know My Father Lives", Value = "302. I Know My Father Lives" });
            hymns.Add(new SelectListItem() { Text = "303. Keep the Commandemnts", Value = "303. Keep the Commandemnts" });
            hymns.Add(new SelectListItem() { Text = "304. Teach Me to Walk in the Light", Value = "304. Teach Me to Walk in the Light" });
            hymns.Add(new SelectListItem() { Text = "305. The Light Divine", Value = "305. The Light Divine" });
            hymns.Add(new SelectListItem() { Text = "306. God's Daily Care", Value = "306. God's Daily Care" });
            hymns.Add(new SelectListItem() { Text = "307. In Our Lovely Deseret", Value = "307. In Our Lovely Deseret" });
            hymns.Add(new SelectListItem() { Text = "308. Love One Another", Value = "308. Love One Another" });
            hymns.Add(new SelectListItem() { Text = "309. As Sisters in Zion", Value = "309. As Sisters in Zion" });
            hymns.Add(new SelectListItem() { Text = "310. A Key Was Turned in Latter Days", Value = "310. A Key Was Turned in Latter Days" });
            hymns.Add(new SelectListItem() { Text = "311. We Meet Again As Sisters", Value = "311. We Meet Again As Sisters" });
            hymns.Add(new SelectListItem() { Text = "312. We Ever Pray For Thee", Value = "312. We Ever Pray For Thee" });
            hymns.Add(new SelectListItem() { Text = "313. God Is Love", Value = "313. God Is Love" });
            hymns.Add(new SelectListItem() { Text = "314. How Gentle God's Commands", Value = "314. How Gentle God's Commands" });
            hymns.Add(new SelectListItem() { Text = "315. Jesus, the Very Thought of Thee", Value = "315. Jesus, the Very Thought of Thee" });
            hymns.Add(new SelectListItem() { Text = "316. The Lord Is My Shepherd", Value = "316. The Lord Is My Shepherd" });
            hymns.Add(new SelectListItem() { Text = "317. Sweet Is the Work", Value = "317. Sweet Is the Work" });
            hymns.Add(new SelectListItem() { Text = "318. Love at Home", Value = "318. Love at Home" });
            hymns.Add(new SelectListItem() { Text = "319. Ye Elders of Israel", Value = "319. Ye Elders of Israel" });
            hymns.Add(new SelectListItem() { Text = "320. The Priesthood of Our Lord", Value = "320. The Priesthood of Our Lord" });
            hymns.Add(new SelectListItem() { Text = "321. Ye Who Are Called to Labor", Value = "321. Ye Who Are Called to Labor" });
            hymns.Add(new SelectListItem() { Text = "322. Come, All Ye Sons of God", Value = "322. Come, All Ye Sons of God" });
            hymns.Add(new SelectListItem() { Text = "323. Rise Up, O Men of God", Value = "323. Rise Up, O Men of God" });
            hymns.Add(new SelectListItem() { Text = "324. Rise Up, O Men of God", Value = "324. Rise Up, O Men of God" });
            hymns.Add(new SelectListItem() { Text = "325. See The Mighty Priesthood Gathered", Value = "325. See The Mighty Priesthood Gathered" });
            hymns.Add(new SelectListItem() { Text = "326. Come, Come Ye Saints", Value = "326. Come, Come Ye Saints" });
            hymns.Add(new SelectListItem() { Text = "327. Go, Ye Messengers of Heaven", Value = "327. Go, Ye Messengers of Heaven" });
            hymns.Add(new SelectListItem() { Text = "328. An Angel From on High", Value = "328. An Angel From on High" });
            hymns.Add(new SelectListItem() { Text = "329. Thy Servants Are Prepared", Value = "329. Thy Servants Are Prepared" });
            hymns.Add(new SelectListItem() { Text = "330. See, The Mighty Angel Flying", Value = "330. See, The Mighty Angel Flying" });
            hymns.Add(new SelectListItem() { Text = "331. Oh Say, What Is Truth?", Value = "331. Oh Say, What Is Truth?" });
            hymns.Add(new SelectListItem() { Text = "332. Come, O Thou Kings of Kings", Value = "332. Come, O Thou Kings of Kings" });
            hymns.Add(new SelectListItem() { Text = "333. High on the Mountain Top", Value = "333. High on the Mountain Top" });
            hymns.Add(new SelectListItem() { Text = "334. I Need Thee Every Hour", Value = "334. I Need Thee Every Hour" });
            hymns.Add(new SelectListItem() { Text = "335. Brightly Beams Our Father's Mercy", Value = "335. Brightly Beams Our Father's Mercy" });
            hymns.Add(new SelectListItem() { Text = "336. School Thy Feelings", Value = "336. School Thy Feelings" });
            hymns.Add(new SelectListItem() { Text = "337. O Home Beloved", Value = "337. O Home Beloved" });
            hymns.Add(new SelectListItem() { Text = "338. America the Beautiful", Value = "338. America the Beautiful" });
            hymns.Add(new SelectListItem() { Text = "339. My Country, 'Tis of Thee/My Country 'Tis of Thee", Value = "339. My Country, 'Tis of Thee/My Country 'Tis of Thee" });
            hymns.Add(new SelectListItem() { Text = "340. The Star-Spangled Banner", Value = "340. The Star-Spangled Banner" });
            hymns.Add(new SelectListItem() { Text = "341. God Save The King|God Save the King", Value = "341. God Save The King|God Save the King" });

            return hymns;
        }
    }
}
