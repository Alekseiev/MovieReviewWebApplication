namespace MovieReviewWebApplication.Infrastructure
{
    public struct MultipleSelectorModel
    {
        public MultipleSelectorModel(long key, string value)
        {
            Key = key;
            Value = value;
        }

        public long Key { get; set; }
        public string Value { get; set; }

    }
}
