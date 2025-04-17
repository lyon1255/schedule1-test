using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x0200049A RID: 1178
	public class ClothingUtility : Singleton<ClothingUtility>
	{
		// Token: 0x0600663A RID: 26170 RVA: 0x001CC2F4 File Offset: 0x001CA4F4
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingUtility()
		{
			Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr);
			ClothingUtility.NativeFieldInfoPtr_ColorDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ColorDataList");
			ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ClothingSlotDataList");
			ClothingUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676217);
			ClothingUtility.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676218);
			ClothingUtility.NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676219);
			ClothingUtility.NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676220);
			ClothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, 100676221);
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x001CC3B0 File Offset: 0x001CA5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206632, XrefRangeEnd = 206687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingUtility.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x001CC3EC File Offset: 0x001CA5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206687, XrefRangeEnd = 206784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x001CC420 File Offset: 0x001CA620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 206798, RefRangeEnd = 206801, XrefRangeStart = 206784, XrefRangeEnd = 206798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility.ColorData GetColorData(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingUtility.ColorData>(intPtr3) : null;
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x001CC46C File Offset: 0x001CA66C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206815, RefRangeEnd = 206817, XrefRangeStart = 206801, XrefRangeEnd = 206815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility.ClothingSlotData GetSlotData(EClothingSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingUtility.ClothingSlotData>(intPtr3) : null;
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x001CC4B8 File Offset: 0x001CA6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206817, XrefRangeEnd = 206834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x000305AE File Offset: 0x0002E7AE
		public ClothingUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06006641 RID: 26177 RVA: 0x001CC4F4 File Offset: 0x001CA6F4
		// (set) Token: 0x06006642 RID: 26178 RVA: 0x000305B7 File Offset: 0x0002E7B7
		public unsafe List<ClothingUtility.ColorData> ColorDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ColorDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingUtility.ColorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ColorDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06006643 RID: 26179 RVA: 0x001CC524 File Offset: 0x001CA724
		// (set) Token: 0x06006644 RID: 26180 RVA: 0x000305D6 File Offset: 0x0002E7D6
		public unsafe List<ClothingUtility.ClothingSlotData> ClothingSlotDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingUtility.ClothingSlotData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.NativeFieldInfoPtr_ClothingSlotDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045C3 RID: 17859
		private static readonly IntPtr NativeFieldInfoPtr_ColorDataList;

		// Token: 0x040045C4 RID: 17860
		private static readonly IntPtr NativeFieldInfoPtr_ClothingSlotDataList;

		// Token: 0x040045C5 RID: 17861
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040045C6 RID: 17862
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040045C7 RID: 17863
		private static readonly IntPtr NativeMethodInfoPtr_GetColorData_Public_ColorData_EClothingColor_0;

		// Token: 0x040045C8 RID: 17864
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotData_Public_ClothingSlotData_EClothingSlot_0;

		// Token: 0x040045C9 RID: 17865
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A31 RID: 2609
		[Serializable]
		public class ColorData : Il2CppSystem.Object
		{
			// Token: 0x0600CF7E RID: 53118 RVA: 0x0031D544 File Offset: 0x0031B744
			// Note: this type is marked as 'beforefieldinit'.
			static ColorData()
			{
				Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ColorData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr);
				ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "ColorType");
				ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "ActualColor");
				ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, "LabelColor");
				ClothingUtility.ColorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr, 100676222);
			}

			// Token: 0x0600CF7F RID: 53119 RVA: 0x0031D5C0 File Offset: 0x0031B7C0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.ColorData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.ColorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF80 RID: 53120 RVA: 0x00064F47 File Offset: 0x00063147
			public ColorData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700407C RID: 16508
			// (get) Token: 0x0600CF81 RID: 53121 RVA: 0x0031D5FC File Offset: 0x0031B7FC
			// (set) Token: 0x0600CF82 RID: 53122 RVA: 0x00064F50 File Offset: 0x00063150
			public unsafe EClothingColor ColorType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ColorType)) = value;
				}
			}

			// Token: 0x1700407D RID: 16509
			// (get) Token: 0x0600CF83 RID: 53123 RVA: 0x0031D624 File Offset: 0x0031B824
			// (set) Token: 0x0600CF84 RID: 53124 RVA: 0x00064F6B File Offset: 0x0006316B
			public unsafe Color ActualColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_ActualColor)) = value;
				}
			}

			// Token: 0x1700407E RID: 16510
			// (get) Token: 0x0600CF85 RID: 53125 RVA: 0x0031D64C File Offset: 0x0031B84C
			// (set) Token: 0x0600CF86 RID: 53126 RVA: 0x00064F86 File Offset: 0x00063186
			public unsafe Color LabelColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ColorData.NativeFieldInfoPtr_LabelColor)) = value;
				}
			}

			// Token: 0x04008BF2 RID: 35826
			private static readonly IntPtr NativeFieldInfoPtr_ColorType;

			// Token: 0x04008BF3 RID: 35827
			private static readonly IntPtr NativeFieldInfoPtr_ActualColor;

			// Token: 0x04008BF4 RID: 35828
			private static readonly IntPtr NativeFieldInfoPtr_LabelColor;

			// Token: 0x04008BF5 RID: 35829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A32 RID: 2610
		[Serializable]
		public class ClothingSlotData : Il2CppSystem.Object
		{
			// Token: 0x0600CF87 RID: 53127 RVA: 0x0031D674 File Offset: 0x0031B874
			// Note: this type is marked as 'beforefieldinit'.
			static ClothingSlotData()
			{
				Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "ClothingSlotData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr);
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Slot");
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Name");
				ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, "Icon");
				ClothingUtility.ClothingSlotData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr, 100676223);
			}

			// Token: 0x0600CF88 RID: 53128 RVA: 0x0031D6F0 File Offset: 0x0031B8F0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClothingSlotData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.ClothingSlotData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.ClothingSlotData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF89 RID: 53129 RVA: 0x00064FA1 File Offset: 0x000631A1
			public ClothingSlotData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700407F RID: 16511
			// (get) Token: 0x0600CF8A RID: 53130 RVA: 0x0031D72C File Offset: 0x0031B92C
			// (set) Token: 0x0600CF8B RID: 53131 RVA: 0x00064FAA File Offset: 0x000631AA
			public unsafe EClothingSlot Slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Slot)) = value;
				}
			}

			// Token: 0x17004080 RID: 16512
			// (get) Token: 0x0600CF8C RID: 53132 RVA: 0x0031D754 File Offset: 0x0031B954
			// (set) Token: 0x0600CF8D RID: 53133 RVA: 0x00064FC5 File Offset: 0x000631C5
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004081 RID: 16513
			// (get) Token: 0x0600CF8E RID: 53134 RVA: 0x0031D77C File Offset: 0x0031B97C
			// (set) Token: 0x0600CF8F RID: 53135 RVA: 0x00064FE4 File Offset: 0x000631E4
			public unsafe Sprite Icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.ClothingSlotData.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BF6 RID: 35830
			private static readonly IntPtr NativeFieldInfoPtr_Slot;

			// Token: 0x04008BF7 RID: 35831
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008BF8 RID: 35832
			private static readonly IntPtr NativeFieldInfoPtr_Icon;

			// Token: 0x04008BF9 RID: 35833
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A33 RID: 2611
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF90 RID: 53136 RVA: 0x0031D7AC File Offset: 0x0031B9AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, 100676224);
				ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr, 100676225);
			}

			// Token: 0x0600CF91 RID: 53137 RVA: 0x0031D814 File Offset: 0x0031BA14
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF92 RID: 53138 RVA: 0x0031D850 File Offset: 0x0031BA50
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass4_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF93 RID: 53139 RVA: 0x00065003 File Offset: 0x00063203
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004082 RID: 16514
			// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x0031D8A0 File Offset: 0x0031BAA0
			// (set) Token: 0x0600CF95 RID: 53141 RVA: 0x0006500C File Offset: 0x0006320C
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass4_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008BFA RID: 35834
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008BFB RID: 35835
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BFC RID: 35836
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A34 RID: 2612
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF96 RID: 53142 RVA: 0x0031D8C8 File Offset: 0x0031BAC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, 100676226);
				ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr, 100676227);
			}

			// Token: 0x0600CF97 RID: 53143 RVA: 0x0031D930 File Offset: 0x0031BB30
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF98 RID: 53144 RVA: 0x0031D96C File Offset: 0x0031BB6C
			[CallerCount(0)]
			public unsafe bool _OnValidate_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF99 RID: 53145 RVA: 0x00065027 File Offset: 0x00063227
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004083 RID: 16515
			// (get) Token: 0x0600CF9A RID: 53146 RVA: 0x0031D9BC File Offset: 0x0031BBBC
			// (set) Token: 0x0600CF9B RID: 53147 RVA: 0x00065030 File Offset: 0x00063230
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008BFD RID: 35837
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008BFE RID: 35838
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BFF RID: 35839
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A35 RID: 2613
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Il2CppSystem.Object
		{
			// Token: 0x0600CF9C RID: 53148 RVA: 0x0031D9E4 File Offset: 0x0031BBE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, "slot");
				ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, 100676228);
				ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr, 100676229);
			}

			// Token: 0x0600CF9D RID: 53149 RVA: 0x0031DA4C File Offset: 0x0031BC4C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF9E RID: 53150 RVA: 0x0031DA88 File Offset: 0x0031BC88
			[CallerCount(0)]
			public unsafe bool _OnValidate_b__1(ClothingUtility.ClothingSlotData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass5_1.NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CF9F RID: 53151 RVA: 0x0006504B File Offset: 0x0006324B
			public __c__DisplayClass5_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004084 RID: 16516
			// (get) Token: 0x0600CFA0 RID: 53152 RVA: 0x0031DAD8 File Offset: 0x0031BCD8
			// (set) Token: 0x0600CFA1 RID: 53153 RVA: 0x00065054 File Offset: 0x00063254
			public unsafe EClothingSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass5_1.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x04008C00 RID: 35840
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04008C01 RID: 35841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C02 RID: 35842
			private static readonly IntPtr NativeMethodInfoPtr__OnValidate_b__1_Internal_Boolean_ClothingSlotData_0;
		}

		// Token: 0x02000A36 RID: 2614
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFA2 RID: 53154 RVA: 0x0031DB00 File Offset: 0x0031BD00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, "color");
				ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, 100676230);
				ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr, 100676231);
			}

			// Token: 0x0600CFA3 RID: 53155 RVA: 0x0031DB68 File Offset: 0x0031BD68
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFA4 RID: 53156 RVA: 0x0031DBA4 File Offset: 0x0031BDA4
			[CallerCount(0)]
			public unsafe bool _GetColorData_b__0(ClothingUtility.ColorData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass6_0.NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFA5 RID: 53157 RVA: 0x0006506F File Offset: 0x0006326F
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004085 RID: 16517
			// (get) Token: 0x0600CFA6 RID: 53158 RVA: 0x0031DBF4 File Offset: 0x0031BDF4
			// (set) Token: 0x0600CFA7 RID: 53159 RVA: 0x00065078 File Offset: 0x00063278
			public unsafe EClothingColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass6_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04008C03 RID: 35843
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04008C04 RID: 35844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C05 RID: 35845
			private static readonly IntPtr NativeMethodInfoPtr__GetColorData_b__0_Internal_Boolean_ColorData_0;
		}

		// Token: 0x02000A37 RID: 2615
		[ObfuscatedName("ScheduleOne.Clothing.ClothingUtility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFA8 RID: 53160 RVA: 0x0031DC1C File Offset: 0x0031BE1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClothingUtility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr);
				ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, "slot");
				ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, 100676232);
				ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr, 100676233);
			}

			// Token: 0x0600CFA9 RID: 53161 RVA: 0x0031DC84 File Offset: 0x0031BE84
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingUtility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFAA RID: 53162 RVA: 0x0031DCC0 File Offset: 0x0031BEC0
			[CallerCount(0)]
			public unsafe bool _GetSlotData_b__0(ClothingUtility.ClothingSlotData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingUtility.__c__DisplayClass7_0.NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFAB RID: 53163 RVA: 0x00065093 File Offset: 0x00063293
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004086 RID: 16518
			// (get) Token: 0x0600CFAC RID: 53164 RVA: 0x0031DD10 File Offset: 0x0031BF10
			// (set) Token: 0x0600CFAD RID: 53165 RVA: 0x0006509C File Offset: 0x0006329C
			public unsafe EClothingSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingUtility.__c__DisplayClass7_0.NativeFieldInfoPtr_slot)) = value;
				}
			}

			// Token: 0x04008C06 RID: 35846
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04008C07 RID: 35847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C08 RID: 35848
			private static readonly IntPtr NativeMethodInfoPtr__GetSlotData_b__0_Internal_Boolean_ClothingSlotData_0;
		}
	}
}
