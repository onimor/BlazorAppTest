namespace BlazorAppTest.Dto
{
    public class RepBatchIDH
    {
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// IDH продукции  
        /// </summary>
        public int IDH { get; set; }
        /// <summary>
        /// Название категории продукта     
        /// </summary>
        public string ProdName { get; set; }
        /// <summary>
        /// Описание продукта      
        /// </summary>
        public string ProdDesc { get; set; }
        /// <summary>
        /// Номинал одной пачки в граммах      
        /// </summary>
        public int Nominal { get; set; }
        /// <summary>
        /// Количество пачек в упаковке       
        /// </summary>
        public int QnPerBox { get; set; }
        /// <summary>
        /// Смена (А, Б, В)       
        /// </summary>
        public string Shift { get; set; }
        /// <summary>
        /// Номер партии       
        /// </summary>
        public int PartNum { get; set; }
        /// <summary>
        /// Название линии     
        /// </summary>
        public string LineName { get; set; }
        /// <summary>
        /// Блок веса пачек, вес №1    
        /// </summary>
        public float Weight1 { get; set; }
        /// <summary>
        /// Блок веса пачек, вес №2    
        /// </summary>
        public float Weight2 { get; set; }
        /// <summary>
        /// Блок веса пачек, вес №3    
        /// </summary>
        public float Weight3 { get; set; }
        /// <summary>
        /// Блок веса пачек, вес №4    
        /// </summary>
        public float Weight4 { get; set; }
        /// <summary>
        /// Блок веса пачек, вес №5    
        /// </summary>
        public float Weight5 { get; set; }
        /// <summary>
        /// Блок веса пачек, вес №6    
        /// </summary>
        public float Weight6 { get; set; }
        /// <summary>
        /// Блок веса пачек, средний вес    
        /// </summary>
        public float WeightAver { get; set; }
        /// <summary>
        /// Блок веса пачек, статус веса №1    
        /// </summary>
        public int StatW1 { get; set; }
        /// <summary>
        /// Блок веса пачек, статус веса №1    
        /// </summary>
        public int StatW2 { get; set; }
        /// <summary>
        /// Блок веса пачек, статус веса №1    
        /// </summary>
        public int StatW3 { get; set; }
        /// <summary>
        /// Блок веса пачек, статус веса №1    
        /// </summary>
        public int StatW4 { get; set; }
        /// <summary>
        /// Блок веса пачек, статус веса №1    
        /// </summary>
        public int StatW5 { get; set; }
        /// <summary>
        /// Блок веса пачек, статус веса №1    
        /// </summary>
        public int StatW6 { get; set; }
        /// <summary>
        /// Блок веса пачек, статус веса №1    
        /// </summary>
        public int StatWaver { get; set; }
    }
}
