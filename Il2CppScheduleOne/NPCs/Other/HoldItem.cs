using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x020002F4 RID: 756
	public class HoldItem : MonoBehaviour
	{
		// Token: 0x06003922 RID: 14626 RVA: 0x0012A364 File Offset: 0x00128564
		// Note: this type is marked as 'beforefieldinit'.
		static HoldItem()
		{
			Il2CppClassPointerStore<HoldItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "HoldItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoldItem>.NativeClassPtr);
			HoldItem.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, "Npc");
			HoldItem.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, "Equippable");
			HoldItem.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, "<active>k__BackingField");
			HoldItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100669946);
			HoldItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100669947);
			HoldItem.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100669948);
			HoldItem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100669949);
			HoldItem.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100669950);
			HoldItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoldItem>.NativeClassPtr, 100669951);
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x0012A448 File Offset: 0x00128648
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x0012A484 File Offset: 0x00128684
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x0012A4C4 File Offset: 0x001286C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141814, XrefRangeEnd = 141816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x0012A4F8 File Offset: 0x001286F8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x0012A52C File Offset: 0x0012872C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141816, XrefRangeEnd = 141820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x0012A560 File Offset: 0x00128760
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HoldItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoldItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HoldItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0001D5DD File Offset: 0x0001B7DD
		public HoldItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x0600392A RID: 14634 RVA: 0x0012A59C File Offset: 0x0012879C
		// (set) Token: 0x0600392B RID: 14635 RVA: 0x0001D5E6 File Offset: 0x0001B7E6
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600392C RID: 14636 RVA: 0x0012A5CC File Offset: 0x001287CC
		// (set) Token: 0x0600392D RID: 14637 RVA: 0x0001D605 File Offset: 0x0001B805
		public unsafe AvatarEquippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x0012A5FC File Offset: 0x001287FC
		// (set) Token: 0x0600392F RID: 14639 RVA: 0x0001D624 File Offset: 0x0001B824
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HoldItem.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
