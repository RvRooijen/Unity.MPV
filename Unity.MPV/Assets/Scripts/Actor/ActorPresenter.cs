public interface IActorPresenter
{
	
}

public class ActorPresenter : IActorPresenter
{
	private IActorView actorView;

	public ActorPresenter(IActorView actorView, Actor actor)
	{
		this.actorView = actorView;
		
		actorView.UpdateName(actor.Name);
		actorView.UpdateHealth(actor.MaxHealth);
		actorView.UpdateMana(actor.Mana);
	}
}
