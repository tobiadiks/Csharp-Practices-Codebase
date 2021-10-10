namespace FirstApp{
    class Dog{
    public string Breed {get;set;}
    public string Color {get;set;}

    public string Bark(){
        return "Woof";
    }
    public string Walk(string direction){
    return $"{Color} {Breed} Walked {direction}";
    }

    public string Detail(){
        return $"Your {Color} dog is a {Breed}";
    }
    }
}