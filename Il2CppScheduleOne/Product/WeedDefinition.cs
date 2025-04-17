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
	// Token: 0x020005B0 RID: 1456
	[Serializable]
	public class WeedDefinition : ProductDefinition
	{
		// Token: 0x06007FF8 RID: 32760 RVA: 0x00223DF4 File Offset: 0x00221FF4
		// Note: this type is marked as 'beforefieldinit'.
		static WeedDefinition()
		{
			Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr);
			WeedDefinition.NativeFieldInfoPtr_MainMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "MainMat");
			WeedDefinition.NativeFieldInfoPtr_SecondaryMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "SecondaryMat");
			WeedDefinition.NativeFieldInfoPtr_LeafMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "LeafMat");
			WeedDefinition.NativeFieldInfoPtr_StemMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "StemMat");
			WeedDefinition.NativeFieldInfoPtr_appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "appearance");
			WeedDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679372);
			WeedDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679373);
			WeedDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679374);
			WeedDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679375);
			WeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, 100679376);
		}

		// Token: 0x06007FF9 RID: 32761 RVA: 0x00223EEC File Offset: 0x002220EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243482, XrefRangeEnd = 243486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007FFA RID: 32762 RVA: 0x00223F44 File Offset: 0x00222144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243520, RefRangeEnd = 243522, XrefRangeStart = 243486, XrefRangeEnd = 243520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Property> properties, List<EDrugType> drugTypes, WeedAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FFB RID: 32763 RVA: 0x00223FAC File Offset: 0x002221AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243522, XrefRangeEnd = 243540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedDefinition.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007FFC RID: 32764 RVA: 0x00223FF0 File Offset: 0x002221F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243619, RefRangeEnd = 243621, XrefRangeStart = 243540, XrefRangeEnd = 243619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedAppearanceSettings GetAppearanceSettings(List<Property> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007FFD RID: 32765 RVA: 0x00224034 File Offset: 0x00222234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FFE RID: 32766 RVA: 0x0003CA9E File Offset: 0x0003AC9E
		public WeedDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x06007FFF RID: 32767 RVA: 0x00224070 File Offset: 0x00222270
		// (set) Token: 0x06008000 RID: 32768 RVA: 0x0003CAA7 File Offset: 0x0003ACA7
		public unsafe Material MainMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_MainMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_MainMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x06008001 RID: 32769 RVA: 0x002240A0 File Offset: 0x002222A0
		// (set) Token: 0x06008002 RID: 32770 RVA: 0x0003CAC6 File Offset: 0x0003ACC6
		public unsafe Material SecondaryMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_SecondaryMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_SecondaryMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x06008003 RID: 32771 RVA: 0x002240D0 File Offset: 0x002222D0
		// (set) Token: 0x06008004 RID: 32772 RVA: 0x0003CAE5 File Offset: 0x0003ACE5
		public unsafe Material LeafMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_LeafMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_LeafMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x06008005 RID: 32773 RVA: 0x00224100 File Offset: 0x00222300
		// (set) Token: 0x06008006 RID: 32774 RVA: 0x0003CB04 File Offset: 0x0003AD04
		public unsafe Material StemMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_StemMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_StemMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x06008007 RID: 32775 RVA: 0x00224130 File Offset: 0x00222330
		// (set) Token: 0x06008008 RID: 32776 RVA: 0x0003CB23 File Offset: 0x0003AD23
		public unsafe WeedAppearanceSettings appearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_appearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedDefinition.NativeFieldInfoPtr_appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005730 RID: 22320
		private static readonly IntPtr NativeFieldInfoPtr_MainMat;

		// Token: 0x04005731 RID: 22321
		private static readonly IntPtr NativeFieldInfoPtr_SecondaryMat;

		// Token: 0x04005732 RID: 22322
		private static readonly IntPtr NativeFieldInfoPtr_LeafMat;

		// Token: 0x04005733 RID: 22323
		private static readonly IntPtr NativeFieldInfoPtr_StemMat;

		// Token: 0x04005734 RID: 22324
		private static readonly IntPtr NativeFieldInfoPtr_appearance;

		// Token: 0x04005735 RID: 22325
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005736 RID: 22326
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Property_List_1_EDrugType_WeedAppearanceSettings_0;

		// Token: 0x04005737 RID: 22327
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04005738 RID: 22328
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_WeedAppearanceSettings_List_1_Property_0;

		// Token: 0x04005739 RID: 22329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADD RID: 2781
		[ObfuscatedName("ScheduleOne.Product.WeedDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D4E6 RID: 54502 RVA: 0x0032C4CC File Offset: 0x0032A6CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeedDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr);
				WeedDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, "<>9");
				WeedDefinition.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, "<>9__8_0");
				WeedDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, 100679378);
				WeedDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr, 100679379);
			}

			// Token: 0x0600D4E7 RID: 54503 RVA: 0x0032C548 File Offset: 0x0032A748
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4E8 RID: 54504 RVA: 0x0032C584 File Offset: 0x0032A784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__8_0(Property x, Property y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4E9 RID: 54505 RVA: 0x000679A1 File Offset: 0x00065BA1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F7 RID: 16887
			// (get) Token: 0x0600D4EA RID: 54506 RVA: 0x0032C5E4 File Offset: 0x0032A7E4
			// (set) Token: 0x0600D4EB RID: 54507 RVA: 0x000679AA File Offset: 0x00065BAA
			public unsafe static WeedDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeedDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeedDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F8 RID: 16888
			// (get) Token: 0x0600D4EC RID: 54508 RVA: 0x0032C60C File Offset: 0x0032A80C
			// (set) Token: 0x0600D4ED RID: 54509 RVA: 0x000679BC File Offset: 0x00065BBC
			public unsafe static Comparison<Property> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WeedDefinition.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Property>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WeedDefinition.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F3C RID: 36668
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F3D RID: 36669
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008F3E RID: 36670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F3F RID: 36671
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__8_0_Internal_Int32_Property_Property_0;
		}
	}
}
