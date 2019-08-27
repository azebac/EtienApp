import { Base } from './base';
import { ThemeService } from 'ng2-charts';

export class Country extends Base {
    private Name:string;
    private ISO: string;
    private NiceName: string;
    private ISO3: string;
    private NumCode: string;
    private PhoneCode:string;


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
     * Getter $NumCode
     * @return {string}
     */
	public get $NumCode(): string {
		return this.NumCode;
	}

    /**
     * Getter $PhoneCode
     * @return {string}
     */
	public get $PhoneCode(): string {
		return this.PhoneCode;
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
     * Setter $NumCode
     * @param {string} value
     */
	public set $NumCode(value: string) {
		this.NumCode = value;
	}

    /**
     * Setter $PhoneCode
     * @param {string} value
     */
	public set $PhoneCode(value: string) {
		this.PhoneCode = value;
    }
    

	constructor(data?) {
        super(data);
        if(data){
        this.Name = data.Name || "";
        this.ISO = data.ISO || "";
        this.NiceName = data.NiceName || "";
        this.ISO3 = data.ISO3 || "";
        this.NumCode = data.NumCode || "";
        this.PhoneCode = data.PhoneCode || "";
        }
    }


}
