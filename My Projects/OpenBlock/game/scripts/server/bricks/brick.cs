// Default brick data.new ScriptObject(BrickDefinition) {		// Model & shape	model      = "art/shapes/bricks/1x1.dts"; // Shape model	ghostmodel = "art/shapes/bricks/1x1.dts"; // Ghost brick model, leave blank if same as above.	brickScale = "1 1 1";  // How much to scale original brick.	category   = "Blocks"; // Category	collisionType = "Collision Mesh"; // Collision type.};function BrickDefinition::serialise(%this) {	return (		%model TAB		%brickScale	);}function BrickDefinition::deserialise(%this, %data) {	// not implemented}