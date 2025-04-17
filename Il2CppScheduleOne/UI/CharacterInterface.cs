using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062B RID: 1579
	public class CharacterInterface : MonoBehaviour
	{
		// Token: 0x06008B39 RID: 35641 RVA: 0x00246C64 File Offset: 0x00244E64
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterInterface()
		{
			Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CharacterInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr);
			CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterInterface.NativeFieldInfoPtr_ClothingSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "ClothingSlots");
			CharacterInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "Container");
			CharacterInterface.NativeFieldInfoPtr_RotationSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "RotationSlider");
			CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "SlotAlignmentPoints");
			CharacterInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680589);
			CharacterInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680590);
			CharacterInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680591);
			CharacterInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680592);
			CharacterInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680593);
			CharacterInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680594);
			CharacterInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, 100680595);
		}

		// Token: 0x17002A77 RID: 10871
		// (get) Token: 0x06008B3A RID: 35642 RVA: 0x00246D84 File Offset: 0x00244F84
		// (set) Token: 0x06008B3B RID: 35643 RVA: 0x00246DC0 File Offset: 0x00244FC0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008B3C RID: 35644 RVA: 0x00246E00 File Offset: 0x00245000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254856, RefRangeEnd = 254857, XrefRangeStart = 254853, XrefRangeEnd = 254856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B3D RID: 35645 RVA: 0x00246E34 File Offset: 0x00245034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254874, RefRangeEnd = 254875, XrefRangeStart = 254857, XrefRangeEnd = 254874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x00246E68 File Offset: 0x00245068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254924, RefRangeEnd = 254925, XrefRangeStart = 254875, XrefRangeEnd = 254924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x00246E9C File Offset: 0x0024509C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254856, RefRangeEnd = 254857, XrefRangeStart = 254856, XrefRangeEnd = 254857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x00246ED0 File Offset: 0x002450D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254925, XrefRangeEnd = 254933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x00042A7B File Offset: 0x00040C7B
		public CharacterInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A72 RID: 10866
		// (get) Token: 0x06008B42 RID: 35650 RVA: 0x00246F0C File Offset: 0x0024510C
		// (set) Token: 0x06008B43 RID: 35651 RVA: 0x00042A84 File Offset: 0x00040C84
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A73 RID: 10867
		// (get) Token: 0x06008B44 RID: 35652 RVA: 0x00246F34 File Offset: 0x00245134
		// (set) Token: 0x06008B45 RID: 35653 RVA: 0x00042A9F File Offset: 0x00040C9F
		public unsafe Il2CppReferenceArray<ClothingSlotUI> ClothingSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_ClothingSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClothingSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_ClothingSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A74 RID: 10868
		// (get) Token: 0x06008B46 RID: 35654 RVA: 0x00246F64 File Offset: 0x00245164
		// (set) Token: 0x06008B47 RID: 35655 RVA: 0x00042ABE File Offset: 0x00040CBE
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A75 RID: 10869
		// (get) Token: 0x06008B48 RID: 35656 RVA: 0x00246F94 File Offset: 0x00245194
		// (set) Token: 0x06008B49 RID: 35657 RVA: 0x00042ADD File Offset: 0x00040CDD
		public unsafe Slider RotationSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_RotationSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_RotationSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A76 RID: 10870
		// (get) Token: 0x06008B4A RID: 35658 RVA: 0x00246FC4 File Offset: 0x002451C4
		// (set) Token: 0x06008B4B RID: 35659 RVA: 0x00042AFC File Offset: 0x00040CFC
		public unsafe Dictionary<ClothingSlotUI, Transform> SlotAlignmentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ClothingSlotUI, Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.NativeFieldInfoPtr_SlotAlignmentPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E66 RID: 24166
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005E67 RID: 24167
		private static readonly IntPtr NativeFieldInfoPtr_ClothingSlots;

		// Token: 0x04005E68 RID: 24168
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005E69 RID: 24169
		private static readonly IntPtr NativeFieldInfoPtr_RotationSlider;

		// Token: 0x04005E6A RID: 24170
		private static readonly IntPtr NativeFieldInfoPtr_SlotAlignmentPoints;

		// Token: 0x04005E6B RID: 24171
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005E6C RID: 24172
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E6D RID: 24173
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005E6E RID: 24174
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005E6F RID: 24175
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005E70 RID: 24176
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005E71 RID: 24177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B16 RID: 2838
		[ObfuscatedName("ScheduleOne.UI.CharacterInterface+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6CB RID: 54987 RVA: 0x00331BD0 File Offset: 0x0032FDD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterInterface>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr);
				CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, "slotUI");
				CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, 100680596);
				CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr, 100680597);
			}

			// Token: 0x0600D6CC RID: 54988 RVA: 0x00331C38 File Offset: 0x0032FE38
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterInterface.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6CD RID: 54989 RVA: 0x00331C74 File Offset: 0x0032FE74
			[CallerCount(0)]
			public unsafe bool _Open_b__0(CharacterDisplay.SlotAlignmentPoint x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterInterface.__c__DisplayClass10_0.NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D6CE RID: 54990 RVA: 0x00068892 File Offset: 0x00066A92
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700428A RID: 17034
			// (get) Token: 0x0600D6CF RID: 54991 RVA: 0x00331CC4 File Offset: 0x0032FEC4
			// (set) Token: 0x0600D6D0 RID: 54992 RVA: 0x0006889B File Offset: 0x00066A9B
			public unsafe ClothingSlotUI slotUI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingSlotUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterInterface.__c__DisplayClass10_0.NativeFieldInfoPtr_slotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009071 RID: 36977
			private static readonly IntPtr NativeFieldInfoPtr_slotUI;

			// Token: 0x04009072 RID: 36978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009073 RID: 36979
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Boolean_SlotAlignmentPoint_0;
		}
	}
}
