using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A0 RID: 1440
	[Serializable]
	public class MethDefinition : ProductDefinition
	{
		// Token: 0x06007DF9 RID: 32249 RVA: 0x0021B6EC File Offset: 0x002198EC
		// Note: this type is marked as 'beforefieldinit'.
		static MethDefinition()
		{
			Il2CppClassPointerStore<MethDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr);
			MethDefinition.NativeFieldInfoPtr_CrystalMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "CrystalMaterial");
			MethDefinition.NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "TintColor");
			MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			MethDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679047);
			MethDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679048);
			MethDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679049);
			MethDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679050);
			MethDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679051);
			MethDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679052);
			MethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, 100679053);
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06007DFA RID: 32250 RVA: 0x0021B7E4 File Offset: 0x002199E4
		// (set) Token: 0x06007DFB RID: 32251 RVA: 0x0021B824 File Offset: 0x00219A24
		public unsafe MethAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007DFC RID: 32252 RVA: 0x0021B868 File Offset: 0x00219A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238368, XrefRangeEnd = 238412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x0021B8C0 File Offset: 0x00219AC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238431, RefRangeEnd = 238433, XrefRangeStart = 238412, XrefRangeEnd = 238431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, MethAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x0021B928 File Offset: 0x00219B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238433, XrefRangeEnd = 238451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007DFF RID: 32255 RVA: 0x0021B96C File Offset: 0x00219B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238527, RefRangeEnd = 238529, XrefRangeStart = 238451, XrefRangeEnd = 238527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x0021B9B0 File Offset: 0x00219BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238529, XrefRangeEnd = 238530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x0003BDCC File Offset: 0x00039FCC
		public MethDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06007E02 RID: 32258 RVA: 0x0021B9EC File Offset: 0x00219BEC
		// (set) Token: 0x06007E03 RID: 32259 RVA: 0x0003BDD5 File Offset: 0x00039FD5
		public unsafe Material CrystalMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_CrystalMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_CrystalMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06007E04 RID: 32260 RVA: 0x0021BA1C File Offset: 0x00219C1C
		// (set) Token: 0x06007E05 RID: 32261 RVA: 0x0003BDF4 File Offset: 0x00039FF4
		public unsafe Color TintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_TintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr_TintColor)) = value;
			}
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x06007E06 RID: 32262 RVA: 0x0021BA44 File Offset: 0x00219C44
		// (set) Token: 0x06007E07 RID: 32263 RVA: 0x0003BE0F File Offset: 0x0003A00F
		public unsafe MethAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040055BE RID: 21950
		private static readonly IntPtr NativeFieldInfoPtr_CrystalMaterial;

		// Token: 0x040055BF RID: 21951
		private static readonly IntPtr NativeFieldInfoPtr_TintColor;

		// Token: 0x040055C0 RID: 21952
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x040055C1 RID: 21953
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_MethAppearanceSettings_0;

		// Token: 0x040055C2 RID: 21954
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_MethAppearanceSettings_0;

		// Token: 0x040055C3 RID: 21955
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040055C4 RID: 21956
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_MethAppearanceSettings_0;

		// Token: 0x040055C5 RID: 21957
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x040055C6 RID: 21958
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_MethAppearanceSettings_List_1_Property_0;

		// Token: 0x040055C7 RID: 21959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC5 RID: 2757
		[ObfuscatedName("ScheduleOne.Product.MethDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D40F RID: 54287 RVA: 0x00329F7C File Offset: 0x0032817C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MethDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr);
				MethDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, "<>9");
				MethDefinition.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, "<>9__9_0");
				MethDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, 100679055);
				MethDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr, 100679056);
			}

			// Token: 0x0600D410 RID: 54288 RVA: 0x00329FF8 File Offset: 0x003281F8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D411 RID: 54289 RVA: 0x0032A034 File Offset: 0x00328234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__9_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D412 RID: 54290 RVA: 0x0006736E File Offset: 0x0006556E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BE RID: 16830
			// (get) Token: 0x0600D413 RID: 54291 RVA: 0x0032A094 File Offset: 0x00328294
			// (set) Token: 0x0600D414 RID: 54292 RVA: 0x00067377 File Offset: 0x00065577
			public unsafe static MethDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BF RID: 16831
			// (get) Token: 0x0600D415 RID: 54293 RVA: 0x0032A0BC File Offset: 0x003282BC
			// (set) Token: 0x0600D416 RID: 54294 RVA: 0x00067389 File Offset: 0x00065589
			public unsafe static Comparison<Property> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MethDefinition.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MethDefinition.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ECC RID: 36556
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ECD RID: 36557
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008ECE RID: 36558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ECF RID: 36559
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__9_0_Internal_Int32_Property_Property_0;
		}
	}
}
