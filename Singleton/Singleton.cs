class Counter{
    public int count=0;
    private static Counter ?counter = null;
    private static object lockObject= new object();
    private Counter(){}
    public static Counter GetInstance(){
        lock(lockObject){
            if(counter == null){
            counter = new Counter();
            }
            return counter;
        }
    }
    public void AddOne(){
        count++;
    }
}