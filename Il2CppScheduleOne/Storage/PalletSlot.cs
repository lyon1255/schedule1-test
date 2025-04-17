using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200056F RID: 1391
	public class PalletSlot : MonoBehaviour
	{
		// Token: 0x06007A7F RID: 31359 RVA: 0x0020FB1C File Offset: 0x0020DD1C
		// Note: this type is marked as 'beforefieldinit'.
		static PalletSlot()
		{
			Il2CppClassPointerStore<PalletSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr);
			PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "<GUID>k__BackingField");
			PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "<occupant>k__BackingField");
			PalletSlot.NativeFieldInfoPtr_onPalletAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "onPalletAdded");
			PalletSlot.NativeFieldInfoPtr_onPalletRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "onPalletRemoved");
			PalletSlot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678642);
			PalletSlot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678643);
			PalletSlot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678644);
			PalletSlot.NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678645);
			PalletSlot.NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678646);
			PalletSlot.NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678647);
			PalletSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678648);
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x06007A80 RID: 31360 RVA: 0x0020FC28 File Offset: 0x0020DE28
		// (set) Token: 0x06007A81 RID: 31361 RVA: 0x0020FC64 File Offset: 0x0020DE64
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x0020FCA4 File Offset: 0x0020DEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234660, XrefRangeEnd = 234664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x06007A83 RID: 31363 RVA: 0x0020FCE4 File Offset: 0x0020DEE4
		// (set) Token: 0x06007A84 RID: 31364 RVA: 0x0020FD24 File Offset: 0x0020DF24
		public unsafe Pallet occupant
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x0020FD68 File Offset: 0x0020DF68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234670, RefRangeEnd = 234672, XrefRangeStart = 234664, XrefRangeEnd = 234670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(Pallet _occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x0020FDAC File Offset: 0x0020DFAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x0003A3CD File Offset: 0x000385CD
		public PalletSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x06007A88 RID: 31368 RVA: 0x0020FDE8 File Offset: 0x0020DFE8
		// (set) Token: 0x06007A89 RID: 31369 RVA: 0x0003A3D6 File Offset: 0x000385D6
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x06007A8A RID: 31370 RVA: 0x0020FE10 File Offset: 0x0020E010
		// (set) Token: 0x06007A8B RID: 31371 RVA: 0x0003A3F1 File Offset: 0x000385F1
		public unsafe Pallet _occupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x06007A8C RID: 31372 RVA: 0x0020FE40 File Offset: 0x0020E040
		// (set) Token: 0x06007A8D RID: 31373 RVA: 0x0003A410 File Offset: 0x00038610
		public unsafe Action onPalletAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x06007A8E RID: 31374 RVA: 0x0020FE70 File Offset: 0x0020E070
		// (set) Token: 0x06007A8F RID: 31375 RVA: 0x0003A42F File Offset: 0x0003862F
		public unsafe Action onPalletRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005361 RID: 21345
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04005362 RID: 21346
		private static readonly IntPtr NativeFieldInfoPtr__occupant_k__BackingField;

		// Token: 0x04005363 RID: 21347
		private static readonly IntPtr NativeFieldInfoPtr_onPalletAdded;

		// Token: 0x04005364 RID: 21348
		private static readonly IntPtr NativeFieldInfoPtr_onPalletRemoved;

		// Token: 0x04005365 RID: 21349
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04005366 RID: 21350
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04005367 RID: 21351
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04005368 RID: 21352
		private static readonly IntPtr NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0;

		// Token: 0x04005369 RID: 21353
		private static readonly IntPtr NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0;

		// Token: 0x0400536A RID: 21354
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0;

		// Token: 0x0400536B RID: 21355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
