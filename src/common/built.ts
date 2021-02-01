import { BodyParts, BuildSources } from "@/interfaces/common";

export default class Built {
  constructor(
    public parts: BodyParts,
    public headIndex: number = 0,
    public leftArmIndex: number = 0,
    public rightArmIndex: number = 0,
    public torsoIndex: number = 0,
    public baseIndex: number = 0
  ) {}

  getBuild(): BuildSources {
    return {
      head: this.parts.heads[this.headIndex],
      leftArm: this.parts.arms[this.leftArmIndex],
      rightArm: this.parts.arms[this.rightArmIndex],
      torso: this.parts.torsos[this.torsoIndex],
      base: this.parts.bases[this.baseIndex]
    };
  }
  getBodyParts(): BodyParts {
    return {
      heads: this.parts.heads,
      arms: this.parts.arms,
      torsos: this.parts.torsos,
      bases: this.parts.bases
    };
  }
}
