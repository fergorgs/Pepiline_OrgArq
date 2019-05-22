using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpScript : MonoBehaviour
{
	public enum Tipo { TipoR, TipoI, Lw, Sw };

	public Tipo tipo = Tipo.TipoR;
	public string rd, rs, rt;
	public string imm;
	public string end;

	public Color onColor;

	public Tipo getTipo() { return tipo; }
	public void setTipo(Tipo tipo) { this.tipo = tipo; }

	public string getRd() { return rd; }
	public void setRd(string rd) { this.rd = rd; }

	public string getRs() { return rs; }
	public void setRs(string rs) { this.rs = rs; }

	public string getRt() { return rt; }
	public void setRt(string rt) { this.rt = rt; }

	public string getImm() { return imm; }
	public void setImm(string imm) { this.imm = imm; }

	public string getEnd() { return end; }
	public void setEnd(string end) { this.end = end; }

}
