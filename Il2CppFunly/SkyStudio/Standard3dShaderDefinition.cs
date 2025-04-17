using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000116 RID: 278
	public class Standard3dShaderDefinition : BaseShaderDefinition
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x000B3AA0 File Offset: 0x000B1CA0
		// Note: this type is marked as 'beforefieldinit'.
		static Standard3dShaderDefinition()
		{
			Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "Standard3dShaderDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr);
			Standard3dShaderDefinition.NativeFieldInfoPtr_MaxStarSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MaxStarSize");
			Standard3dShaderDefinition.NativeFieldInfoPtr_MaxStarDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MaxStarDensity");
			Standard3dShaderDefinition.NativeFieldInfoPtr_MinEdgeFeathering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MinEdgeFeathering");
			Standard3dShaderDefinition.NativeFieldInfoPtr_MinStarFadeBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MinStarFadeBegin");
			Standard3dShaderDefinition.NativeFieldInfoPtr_MaxSpriteItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MaxSpriteItems");
			Standard3dShaderDefinition.NativeFieldInfoPtr_MinRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MinRotationSpeed");
			Standard3dShaderDefinition.NativeFieldInfoPtr_MaxRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MaxRotationSpeed");
			Standard3dShaderDefinition.NativeFieldInfoPtr_MaxCloudRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MaxCloudRotationSpeed");
			Standard3dShaderDefinition.NativeFieldInfoPtr_MaxHDRValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, "MaxHDRValue");
			Standard3dShaderDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, 100665578);
			Standard3dShaderDefinition.NativeMethodInfoPtr_ProfileFeatureSection_Protected_Virtual_Il2CppReferenceArray_1_ProfileFeatureSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, 100665579);
			Standard3dShaderDefinition.NativeMethodInfoPtr_ProfileDefinitionTable_Protected_Virtual_Il2CppReferenceArray_1_ProfileGroupSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr, 100665580);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000B3BC0 File Offset: 0x000B1DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90698, XrefRangeEnd = 90702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Standard3dShaderDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Standard3dShaderDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Standard3dShaderDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000B3BFC File Offset: 0x000B1DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90702, XrefRangeEnd = 91272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ProfileFeatureSection> ProfileFeatureSection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Standard3dShaderDefinition.NativeMethodInfoPtr_ProfileFeatureSection_Protected_Virtual_Il2CppReferenceArray_1_ProfileFeatureSection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileFeatureSection>>(intPtr3) : null;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000B3C48 File Offset: 0x000B1E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91272, XrefRangeEnd = 92850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ProfileGroupSection> ProfileDefinitionTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Standard3dShaderDefinition.NativeMethodInfoPtr_ProfileDefinitionTable_Protected_Virtual_Il2CppReferenceArray_1_ProfileGroupSection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProfileGroupSection>>(intPtr3) : null;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x0000CF7F File Offset: 0x0000B17F
		public Standard3dShaderDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x000B3C94 File Offset: 0x000B1E94
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x0000CF88 File Offset: 0x0000B188
		public unsafe static float MaxStarSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxStarSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxStarSize, (void*)(&value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x000B3CB0 File Offset: 0x000B1EB0
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x0000CF96 File Offset: 0x0000B196
		public unsafe static float MaxStarDensity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxStarDensity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxStarDensity, (void*)(&value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x000B3CCC File Offset: 0x000B1ECC
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
		public unsafe static float MinEdgeFeathering
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MinEdgeFeathering, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MinEdgeFeathering, (void*)(&value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x000B3CE8 File Offset: 0x000B1EE8
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0000CFB2 File Offset: 0x0000B1B2
		public unsafe static float MinStarFadeBegin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MinStarFadeBegin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MinStarFadeBegin, (void*)(&value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x000B3D04 File Offset: 0x000B1F04
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		public unsafe static float MaxSpriteItems
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxSpriteItems, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxSpriteItems, (void*)(&value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x000B3D20 File Offset: 0x000B1F20
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0000CFCE File Offset: 0x0000B1CE
		public unsafe static float MinRotationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MinRotationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MinRotationSpeed, (void*)(&value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x000B3D3C File Offset: 0x000B1F3C
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		public unsafe static float MaxRotationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxRotationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxRotationSpeed, (void*)(&value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x000B3D58 File Offset: 0x000B1F58
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x0000CFEA File Offset: 0x0000B1EA
		public unsafe static float MaxCloudRotationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxCloudRotationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxCloudRotationSpeed, (void*)(&value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x000B3D74 File Offset: 0x000B1F74
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		public unsafe static float MaxHDRValue
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxHDRValue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Standard3dShaderDefinition.NativeFieldInfoPtr_MaxHDRValue, (void*)(&value));
			}
		}

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeFieldInfoPtr_MaxStarSize;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeFieldInfoPtr_MaxStarDensity;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeFieldInfoPtr_MinEdgeFeathering;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeFieldInfoPtr_MinStarFadeBegin;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeFieldInfoPtr_MaxSpriteItems;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeFieldInfoPtr_MinRotationSpeed;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeFieldInfoPtr_MaxRotationSpeed;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeFieldInfoPtr_MaxCloudRotationSpeed;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeFieldInfoPtr_MaxHDRValue;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_ProfileFeatureSection_Protected_Virtual_Il2CppReferenceArray_1_ProfileFeatureSection_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_ProfileDefinitionTable_Protected_Virtual_Il2CppReferenceArray_1_ProfileGroupSection_0;
	}
}
