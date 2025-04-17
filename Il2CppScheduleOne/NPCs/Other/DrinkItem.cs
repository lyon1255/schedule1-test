using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Other
{
	// Token: 0x020002F3 RID: 755
	public class DrinkItem : MonoBehaviour
	{
		// Token: 0x06003914 RID: 14612 RVA: 0x0012A0A4 File Offset: 0x001282A4
		// Note: this type is marked as 'beforefieldinit'.
		static DrinkItem()
		{
			Il2CppClassPointerStore<DrinkItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Other", "DrinkItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr);
			DrinkItem.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "Npc");
			DrinkItem.NativeFieldInfoPtr_DrinkPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "DrinkPrefab");
			DrinkItem.NativeFieldInfoPtr__active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, "<active>k__BackingField");
			DrinkItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669940);
			DrinkItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669941);
			DrinkItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669942);
			DrinkItem.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669943);
			DrinkItem.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669944);
			DrinkItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr, 100669945);
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x0012A188 File Offset: 0x00128388
		// (set) Token: 0x06003916 RID: 14614 RVA: 0x0012A1C4 File Offset: 0x001283C4
		public unsafe bool active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0012A204 File Offset: 0x00128404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141792, XrefRangeEnd = 141800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0012A238 File Offset: 0x00128438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141800, XrefRangeEnd = 141806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x0012A26C File Offset: 0x0012846C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141806, XrefRangeEnd = 141814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x0012A2A0 File Offset: 0x001284A0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrinkItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrinkItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrinkItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x0001D57B File Offset: 0x0001B77B
		public DrinkItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x0600391C RID: 14620 RVA: 0x0012A2DC File Offset: 0x001284DC
		// (set) Token: 0x0600391D RID: 14621 RVA: 0x0001D584 File Offset: 0x0001B784
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x0600391E RID: 14622 RVA: 0x0012A30C File Offset: 0x0012850C
		// (set) Token: 0x0600391F RID: 14623 RVA: 0x0001D5A3 File Offset: 0x0001B7A3
		public unsafe AvatarEquippable DrinkPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_DrinkPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr_DrinkPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06003920 RID: 14624 RVA: 0x0012A33C File Offset: 0x0012853C
		// (set) Token: 0x06003921 RID: 14625 RVA: 0x0001D5C2 File Offset: 0x0001B7C2
		public unsafe bool _active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrinkItem.NativeFieldInfoPtr__active_k__BackingField)) = value;
			}
		}

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeFieldInfoPtr_DrinkPrefab;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeFieldInfoPtr__active_k__BackingField;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Protected_set_Void_Boolean_0;

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_0;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
