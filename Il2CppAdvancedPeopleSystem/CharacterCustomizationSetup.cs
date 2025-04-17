using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000148 RID: 328
	[Serializable]
	public class CharacterCustomizationSetup : Object
	{
		// Token: 0x06001B3C RID: 6972 RVA: 0x000C5C34 File Offset: 0x000C3E34
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationSetup()
		{
			Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterCustomizationSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr);
			CharacterCustomizationSetup.NativeFieldInfoPtr_settingsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "settingsName");
			CharacterCustomizationSetup.NativeFieldInfoPtr_selectedElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "selectedElements");
			CharacterCustomizationSetup.NativeFieldInfoPtr_blendshapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "blendshapes");
			CharacterCustomizationSetup.NativeFieldInfoPtr_MinLod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "MinLod");
			CharacterCustomizationSetup.NativeFieldInfoPtr_MaxLod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "MaxLod");
			CharacterCustomizationSetup.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "SkinColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_EyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "EyeColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "HairColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_UnderpantsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "UnderpantsColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_TeethColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "TeethColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_OralCavityColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "OralCavityColor");
			CharacterCustomizationSetup.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "Height");
			CharacterCustomizationSetup.NativeFieldInfoPtr_HeadSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, "HeadSize");
			CharacterCustomizationSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, 100666215);
			CharacterCustomizationSetup.NativeMethodInfoPtr_ApplyToCharacter_Public_Void_CharacterCustomization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, 100666216);
			CharacterCustomizationSetup.NativeMethodInfoPtr_Serialize_Public_String_CharacterFileSaveFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, 100666217);
			CharacterCustomizationSetup.NativeMethodInfoPtr_Deserialize_Public_Static_CharacterCustomizationSetup_String_CharacterFileSaveFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr, 100666218);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000C5DB8 File Offset: 0x000C3FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100251, RefRangeEnd = 100252, XrefRangeStart = 100238, XrefRangeEnd = 100251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationSetup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationSetup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000C5DF4 File Offset: 0x000C3FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100268, RefRangeEnd = 100269, XrefRangeStart = 100252, XrefRangeEnd = 100268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyToCharacter(CharacterCustomization cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSetup.NativeMethodInfoPtr_ApplyToCharacter_Public_Void_CharacterCustomization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000C5E38 File Offset: 0x000C4038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100279, RefRangeEnd = 100280, XrefRangeStart = 100269, XrefRangeEnd = 100279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Serialize(CharacterCustomizationSetup.CharacterFileSaveFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSetup.NativeMethodInfoPtr_Serialize_Public_String_CharacterFileSaveFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x000C5E7C File Offset: 0x000C407C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100280, XrefRangeEnd = 100290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterCustomizationSetup Deserialize(string data, CharacterCustomizationSetup.CharacterFileSaveFormat format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationSetup.NativeMethodInfoPtr_Deserialize_Public_Static_CharacterCustomizationSetup_String_CharacterFileSaveFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationSetup>(intPtr3) : null;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0000F5C9 File Offset: 0x0000D7C9
		public CharacterCustomizationSetup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x000C5ED0 File Offset: 0x000C40D0
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0000F5D2 File Offset: 0x0000D7D2
		public unsafe string settingsName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_settingsName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_settingsName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x000C5EF8 File Offset: 0x000C40F8
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0000F5F1 File Offset: 0x0000D7F1
		public unsafe CharacterSelectedElements selectedElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_selectedElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSelectedElements>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_selectedElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x000C5F28 File Offset: 0x000C4128
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0000F610 File Offset: 0x0000D810
		public unsafe List<CharacterBlendshapeData> blendshapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_blendshapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CharacterBlendshapeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_blendshapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x000C5F58 File Offset: 0x000C4158
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0000F62F File Offset: 0x0000D82F
		public unsafe int MinLod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_MinLod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_MinLod)) = value;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x000C5F80 File Offset: 0x000C4180
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0000F64A File Offset: 0x0000D84A
		public unsafe int MaxLod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_MaxLod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_MaxLod)) = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x000C5FA8 File Offset: 0x000C41A8
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0000F665 File Offset: 0x0000D865
		public unsafe Il2CppStructArray<float> SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_SkinColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_SkinColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000C5FD8 File Offset: 0x000C41D8
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0000F684 File Offset: 0x0000D884
		public unsafe Il2CppStructArray<float> EyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_EyeColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_EyeColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x000C6008 File Offset: 0x000C4208
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0000F6A3 File Offset: 0x0000D8A3
		public unsafe Il2CppStructArray<float> HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_HairColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_HairColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x000C6038 File Offset: 0x000C4238
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0000F6C2 File Offset: 0x0000D8C2
		public unsafe Il2CppStructArray<float> UnderpantsColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_UnderpantsColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_UnderpantsColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x000C6068 File Offset: 0x000C4268
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0000F6E1 File Offset: 0x0000D8E1
		public unsafe Il2CppStructArray<float> TeethColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_TeethColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_TeethColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x000C6098 File Offset: 0x000C4298
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x0000F700 File Offset: 0x0000D900
		public unsafe Il2CppStructArray<float> OralCavityColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_OralCavityColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_OralCavityColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x000C60C8 File Offset: 0x000C42C8
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0000F71F File Offset: 0x0000D91F
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x000C60F0 File Offset: 0x000C42F0
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0000F73A File Offset: 0x0000D93A
		public unsafe float HeadSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_HeadSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationSetup.NativeFieldInfoPtr_HeadSize)) = value;
			}
		}

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeFieldInfoPtr_settingsName;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeFieldInfoPtr_selectedElements;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeFieldInfoPtr_blendshapes;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeFieldInfoPtr_MinLod;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeFieldInfoPtr_MaxLod;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeFieldInfoPtr_EyeColor;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeFieldInfoPtr_UnderpantsColor;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeFieldInfoPtr_TeethColor;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeFieldInfoPtr_OralCavityColor;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeFieldInfoPtr_HeadSize;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToCharacter_Public_Void_CharacterCustomization_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_String_CharacterFileSaveFormat_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_CharacterCustomizationSetup_String_CharacterFileSaveFormat_0;

		// Token: 0x02000862 RID: 2146
		[OriginalName("Assembly-CSharp.dll", "", "CharacterFileSaveFormat")]
		public enum CharacterFileSaveFormat
		{
			// Token: 0x040082A0 RID: 33440
			Json,
			// Token: 0x040082A1 RID: 33441
			Xml,
			// Token: 0x040082A2 RID: 33442
			Binary
		}
	}
}
