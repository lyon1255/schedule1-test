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
	// Token: 0x02000597 RID: 1431
	[Serializable]
	public class CocaineDefinition : ProductDefinition
	{
		// Token: 0x06007DC5 RID: 32197 RVA: 0x0021AAB8 File Offset: 0x00218CB8
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineDefinition()
		{
			Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr);
			CocaineDefinition.NativeFieldInfoPtr_RockMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "RockMaterial");
			CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			CocaineDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679018);
			CocaineDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679019);
			CocaineDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679020);
			CocaineDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679021);
			CocaineDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679022);
			CocaineDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679023);
			CocaineDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, 100679024);
		}

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06007DC6 RID: 32198 RVA: 0x0021AB9C File Offset: 0x00218D9C
		// (set) Token: 0x06007DC7 RID: 32199 RVA: 0x0021ABDC File Offset: 0x00218DDC
		public unsafe CocaineAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238077, XrefRangeEnd = 238078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007DC8 RID: 32200 RVA: 0x0021AC20 File Offset: 0x00218E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238078, XrefRangeEnd = 238122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007DC9 RID: 32201 RVA: 0x0021AC78 File Offset: 0x00218E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238141, RefRangeEnd = 238143, XrefRangeStart = 238122, XrefRangeEnd = 238141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, CocaineAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DCA RID: 32202 RVA: 0x0021ACE0 File Offset: 0x00218EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238143, XrefRangeEnd = 238161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007DCB RID: 32203 RVA: 0x0021AD24 File Offset: 0x00218F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238237, RefRangeEnd = 238239, XrefRangeStart = 238161, XrefRangeEnd = 238237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x0021AD68 File Offset: 0x00218F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238239, XrefRangeEnd = 238240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x0003BCE3 File Offset: 0x00039EE3
		public CocaineDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x06007DCE RID: 32206 RVA: 0x0021ADA4 File Offset: 0x00218FA4
		// (set) Token: 0x06007DCF RID: 32207 RVA: 0x0003BCEC File Offset: 0x00039EEC
		public unsafe Material RockMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr_RockMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr_RockMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06007DD0 RID: 32208 RVA: 0x0021ADD4 File Offset: 0x00218FD4
		// (set) Token: 0x06007DD1 RID: 32209 RVA: 0x0003BD0B File Offset: 0x00039F0B
		public unsafe CocaineAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005585 RID: 21893
		private static readonly IntPtr NativeFieldInfoPtr_RockMaterial;

		// Token: 0x04005586 RID: 21894
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x04005587 RID: 21895
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_CocaineAppearanceSettings_0;

		// Token: 0x04005588 RID: 21896
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_CocaineAppearanceSettings_0;

		// Token: 0x04005589 RID: 21897
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x0400558A RID: 21898
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_CocaineAppearanceSettings_0;

		// Token: 0x0400558B RID: 21899
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400558C RID: 21900
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_CocaineAppearanceSettings_List_1_Property_0;

		// Token: 0x0400558D RID: 21901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC4 RID: 2756
		[ObfuscatedName("ScheduleOne.Product.CocaineDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D407 RID: 54279 RVA: 0x00329E14 File Offset: 0x00328014
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CocaineDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr);
				CocaineDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, "<>9");
				CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, "<>9__8_0");
				CocaineDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, 100679026);
				CocaineDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr, 100679027);
			}

			// Token: 0x0600D408 RID: 54280 RVA: 0x00329E90 File Offset: 0x00328090
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D409 RID: 54281 RVA: 0x00329ECC File Offset: 0x003280CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238075, XrefRangeEnd = 238077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__8_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D40A RID: 54282 RVA: 0x00067341 File Offset: 0x00065541
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BC RID: 16828
			// (get) Token: 0x0600D40B RID: 54283 RVA: 0x00329F2C File Offset: 0x0032812C
			// (set) Token: 0x0600D40C RID: 54284 RVA: 0x0006734A File Offset: 0x0006554A
			public unsafe static CocaineDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CocaineDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CocaineDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BD RID: 16829
			// (get) Token: 0x0600D40D RID: 54285 RVA: 0x00329F54 File Offset: 0x00328154
			// (set) Token: 0x0600D40E RID: 54286 RVA: 0x0006735C File Offset: 0x0006555C
			public unsafe static Comparison<Property> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CocaineDefinition.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EC8 RID: 36552
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008EC9 RID: 36553
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008ECA RID: 36554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ECB RID: 36555
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0;
		}
	}
}
