namespace BuilderPattern
{
    internal class Director
    {
        /// <summary>
        /// Method which create a normal pizza
        /// </summary>
        /// <param name="builder">The builder to generate</param>
        internal void makePizzaNormal(IBuilder builder)
        {
            builder.setTomato();
            builder.setCheese();
        }

        /// <summary>
        /// Method which create a double cheese pizza
        /// </summary>
        /// <param name="builder">The builder to generate</param>
        internal void makePizzaDoubleCheese(IBuilder builder)
        {
            builder.setTomato();
            builder.setCheese();
            builder.setCheese();
        }

        /// <summary>
        /// Method which create a pepperoni pizza
        /// </summary>
        /// <param name="builder">The builder to generate</param>
        internal void makePizzaPepperoni(IBuilder builder)
        {
            this.makePizzaNormal(builder);
            builder.setPepperoni();
        }

        /// <summary>
        /// Method which create a complete pizza
        /// </summary>
        /// <param name="builder">The builder to generate</param>
        internal void makePizzaComplete(IBuilder builder)
        {
            this.makePizzaNormal(builder);
            builder.setBacon();
            builder.setHam();
        }
    }
}
