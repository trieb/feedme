namespace feedme
{
    class Tag
    {
        private static int Id = 0; 
        public string TagName { get; set; }

        public Tag(string tagName)
        {
            // TODO: check if tag already exist, if not, add to table. 
            Id++;
            this.TagName = tagName; 
        }
    }
}