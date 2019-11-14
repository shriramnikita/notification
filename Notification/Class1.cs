using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Notification
{
    public class NotesModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>

        [ForeignKey("ApplicationRegisterModel")]
        public string UserId { get; set; }

    
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
       // [Column(TypeName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [pin unpin].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [pin unpin]; otherwise, <c>false</c>.
        /// </value>
   ////     public bool Pin { get; set; }

        /// <summary>
        /// Gets or sets the reminders.
        /// </summary>
        /// <value>
        /// The reminders.
        /// </value>
        public DateTime Reminders { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether this instance is pin.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is pin; otherwise, <c>false</c>.
        /// </value>
        public bool IsPin { get; set; }
    }
}
