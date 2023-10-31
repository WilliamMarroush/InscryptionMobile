using Godot;
using System;

public partial class Card : Sprite2D
{
    public int Health { get; set; }
    public int Price { get; set; }
    public int Attack { get; set; }
    public string Title { get; set; }

    public Card(string name,int health, int price, int attack)
    {
        Title = name;
        Health = health;
        Price = price;
        Attack = attack;
    }
    public override void _Draw(){
        FontFile cardfont = (Font)GD.Load("res://Assets/Fonts/Roboto-Regular.ttf");

        Texture frame = (Texture)GD.Load("res://Assets/Art/Inscryption_card_template.png");
    }
	public void takedamage(int enemy_attack){
		this.Health -= enemy_attack;
	}
	public void attack(ref Card enemy){
		enemy.Health -= this.Attack;
		this.Health -= enemy.Attack;
	}
	public void summon(ref int squirrels){
		if (squirrels >= this.Price){
			squirrels-=this.Price;
		}
	}
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}