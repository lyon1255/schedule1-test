using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000485 RID: 1157
	public class MaterialFeature : OptionListFeature
	{
		// Token: 0x06006461 RID: 25697 RVA: 0x001C6244 File Offset: 0x001C4444
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialFeature()
		{
			Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "MaterialFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr);
			MaterialFeature.NativeFieldInfoPtr_materialTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "materialTargets");
			MaterialFeature.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "materials");
			MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted");
			MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.MaterialFeatureAssembly-CSharp.dll_Excuted");
			MaterialFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676014);
			MaterialFeature.NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676015);
			MaterialFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676016);
			MaterialFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676017);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676018);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676019);
			MaterialFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676020);
			MaterialFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, 100676021);
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x001C6364 File Offset: 0x001C4564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204139, XrefRangeEnd = 204148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SelectOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x001C63B0 File Offset: 0x001C45B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204148, XrefRangeEnd = 204154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterial(MaterialFeature.NamedMaterial mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x001C63F4 File Offset: 0x001C45F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204154, XrefRangeEnd = 204178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<FI_OptionList.Option> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr3) : null;
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x001C6440 File Offset: 0x001C4640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204178, XrefRangeEnd = 204197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x001C647C File Offset: 0x001C467C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204197, XrefRangeEnd = 204198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x001C64B8 File Offset: 0x001C46B8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x001C64F4 File Offset: 0x001C46F4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006469 RID: 25705 RVA: 0x001C6530 File Offset: 0x001C4730
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaterialFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x0002F7BC File Offset: 0x0002D9BC
		public MaterialFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x0600646B RID: 25707 RVA: 0x001C656C File Offset: 0x001C476C
		// (set) Token: 0x0600646C RID: 25708 RVA: 0x0002F7C5 File Offset: 0x0002D9C5
		public unsafe List<MeshRenderer> materialTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materialTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materialTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x0600646D RID: 25709 RVA: 0x001C659C File Offset: 0x001C479C
		// (set) Token: 0x0600646E RID: 25710 RVA: 0x0002F7E4 File Offset: 0x0002D9E4
		public unsafe List<MaterialFeature.NamedMaterial> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialFeature.NamedMaterial>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x0600646F RID: 25711 RVA: 0x001C65CC File Offset: 0x001C47CC
		// (set) Token: 0x06006470 RID: 25712 RVA: 0x0002F803 File Offset: 0x0002DA03
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x06006471 RID: 25713 RVA: 0x001C65F4 File Offset: 0x001C47F4
		// (set) Token: 0x06006472 RID: 25714 RVA: 0x0002F81E File Offset: 0x0002DA1E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400447E RID: 17534
		private static readonly IntPtr NativeFieldInfoPtr_materialTargets;

		// Token: 0x0400447F RID: 17535
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x04004480 RID: 17536
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004481 RID: 17537
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004482 RID: 17538
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0;

		// Token: 0x04004483 RID: 17539
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Private_Void_NamedMaterial_0;

		// Token: 0x04004484 RID: 17540
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0;

		// Token: 0x04004485 RID: 17541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004486 RID: 17542
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004487 RID: 17543
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004488 RID: 17544
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004489 RID: 17545
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A2E RID: 2606
		[Serializable]
		public class NamedMaterial : Il2CppSystem.Object
		{
			// Token: 0x0600CF5D RID: 53085 RVA: 0x0031CFAC File Offset: 0x0031B1AC
			// Note: this type is marked as 'beforefieldinit'.
			static NamedMaterial()
			{
				Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialFeature>.NativeClassPtr, "NamedMaterial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr);
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "matName");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "buttonColor");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "mat");
				MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, "price");
				MaterialFeature.NamedMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr, 100676022);
			}

			// Token: 0x0600CF5E RID: 53086 RVA: 0x0031D03C File Offset: 0x0031B23C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204138, XrefRangeEnd = 204139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamedMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialFeature.NamedMaterial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialFeature.NamedMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF5F RID: 53087 RVA: 0x00064E25 File Offset: 0x00063025
			public NamedMaterial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004071 RID: 16497
			// (get) Token: 0x0600CF60 RID: 53088 RVA: 0x0031D078 File Offset: 0x0031B278
			// (set) Token: 0x0600CF61 RID: 53089 RVA: 0x00064E2E File Offset: 0x0006302E
			public unsafe string matName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_matName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004072 RID: 16498
			// (get) Token: 0x0600CF62 RID: 53090 RVA: 0x0031D0A0 File Offset: 0x0031B2A0
			// (set) Token: 0x0600CF63 RID: 53091 RVA: 0x00064E4D File Offset: 0x0006304D
			public unsafe Color buttonColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_buttonColor)) = value;
				}
			}

			// Token: 0x17004073 RID: 16499
			// (get) Token: 0x0600CF64 RID: 53092 RVA: 0x0031D0C8 File Offset: 0x0031B2C8
			// (set) Token: 0x0600CF65 RID: 53093 RVA: 0x00064E68 File Offset: 0x00063068
			public unsafe Material mat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004074 RID: 16500
			// (get) Token: 0x0600CF66 RID: 53094 RVA: 0x0031D0F8 File Offset: 0x0031B2F8
			// (set) Token: 0x0600CF67 RID: 53095 RVA: 0x00064E87 File Offset: 0x00063087
			public unsafe float price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialFeature.NamedMaterial.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x04008BE0 RID: 35808
			private static readonly IntPtr NativeFieldInfoPtr_matName;

			// Token: 0x04008BE1 RID: 35809
			private static readonly IntPtr NativeFieldInfoPtr_buttonColor;

			// Token: 0x04008BE2 RID: 35810
			private static readonly IntPtr NativeFieldInfoPtr_mat;

			// Token: 0x04008BE3 RID: 35811
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x04008BE4 RID: 35812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
