import { Base } from './base';

export class Country extends Base {
    private Name:string;
    private ISO: string;
    private NiceName: string;
    private ISO3: string;
    private NumCode: number;
    private PhoneCode:number;


    /**
     * Getter $Name
     * @return {string}
     */
	public get $Name(): string {
		return this.Name;
	}

    /**
     * Getter $ISO
     * @return {string}
     */
	public get $ISO(): string {
		return this.ISO;
	}

    /**
     * Getter $NiceName
     * @return {string}
     */
	public get $NiceName(): string {
		return this.NiceName;
	}

    /**
     * Getter $ISO3
     * @return {string}
     */
	public get $ISO3(): string {
		return this.ISO3;
	}

    /**
     * Setter $Name
     * @param {string} value
     */
	public set $Name(value: string) {
		this.Name = value;
	}

    /**
     * Setter $ISO
     * @param {string} value
     */
	public set $ISO(value: string) {
		this.ISO = value;
	}

    /**
     * Setter $NiceName
     * @param {string} value
     */
	public set $NiceName(value: string) {
		this.NiceName = value;
	}

    /**
     * Setter $ISO3
     * @param {string} value
     */
	public set $ISO3(value: string) {
		this.ISO3 = value;
    }
    

    /**
     * Getter $NumCode
     * @return {number}
     */
	public get $NumCode(): number {
		return this.NumCode;
	}

    /**
     * Getter $PhoneCode
     * @return {number}
     */
	public get $PhoneCode(): number {
		return this.PhoneCode;
	}

    /**
     * Setter $NumCode
     * @param {number} value
     */
	public set $NumCode(value: number) {
		this.NumCode = value;
	}

    /**
     * Setter $PhoneCode
     * @param {number} value
     */
	public set $PhoneCode(value: number) {
		this.PhoneCode = value;
	}


	constructor(data?) {
        super(data);
        if(data){
        this.Name = data.Name || "";
        this.ISO = data.ISO || "";
        this.NiceName = data.NiceName || "";
        this.ISO3 = data.ISO3 || "";
        this.NumCode = data.NumCode || 0;
        this.PhoneCode = data.PhoneCode || 0;
        }
    }


}
