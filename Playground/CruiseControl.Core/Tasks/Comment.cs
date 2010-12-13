﻿namespace CruiseControl.Core.Tasks
{
    using System.Windows.Markup;
    using System.Collections.Generic;

    [ContentProperty("Text")]
    public class Comment
        : Task
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Comment"/> class.
        /// </summary>
        public Comment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Comment(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Comment"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="text">The text.</param>
        public Comment(string name, string text)
            : base(name)
        {
            this.Text = text;
        }
        #endregion

        #region Public properties
        #region Text
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get; set; }
        #endregion
        #endregion

        #region Public methods
        #region Execute()
        /// <summary>
        /// Executes this task.
        /// </summary>
        /// <returns>The child tasks to execute.</returns>
        public override IEnumerable<Task> Execute()
        {
            // TODO: Implement this task
            yield break;
        }
        #endregion
        #endregion
    }
}