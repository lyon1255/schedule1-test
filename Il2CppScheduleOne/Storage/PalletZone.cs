using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000571 RID: 1393
	public class PalletZone : MonoBehaviour
	{
		// Token: 0x06007A96 RID: 31382 RVA: 0x0020FFC8 File Offset: 0x0020E1C8
		// Note: this type is marked as 'beforefieldinit'.
		static PalletZone()
		{
			Il2CppClassPointerStore<PalletZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletZone>.NativeClassPtr);
			PalletZone.NativeFieldInfoPtr_pallets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "pallets");
			PalletZone.NativeFieldInfoPtr_palletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "palletPrefab");
			PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "orderReceivedThisFrame");
			PalletZone.NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678651);
			PalletZone.NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678652);
			PalletZone.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678653);
			PalletZone.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678654);
			PalletZone.NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678655);
			PalletZone.NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678656);
			PalletZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100678657);
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x06007A97 RID: 31383 RVA: 0x002100C0 File Offset: 0x0020E2C0
		public unsafe bool isClear
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234674, XrefRangeEnd = 234681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x002100FC File Offset: 0x0020E2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234681, XrefRangeEnd = 234694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x00210140 File Offset: 0x0020E340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234694, XrefRangeEnd = 234696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x00210174 File Offset: 0x0020E374
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 160417, RefRangeEnd = 160430, XrefRangeStart = 160417, XrefRangeEnd = 160430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x002101A8 File Offset: 0x0020E3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234696, XrefRangeEnd = 234713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pallet GeneratePallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr3) : null;
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x002101E8 File Offset: 0x0020E3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234713, XrefRangeEnd = 234719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPalletsClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x00210224 File Offset: 0x0020E424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234719, XrefRangeEnd = 234727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x0003A476 File Offset: 0x00038676
		public PalletZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x06007A9F RID: 31391 RVA: 0x00210260 File Offset: 0x0020E460
		// (set) Token: 0x06007AA0 RID: 31392 RVA: 0x0003A47F File Offset: 0x0003867F
		public unsafe List<Pallet> pallets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_pallets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pallet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_pallets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x06007AA1 RID: 31393 RVA: 0x00210290 File Offset: 0x0020E490
		// (set) Token: 0x06007AA2 RID: 31394 RVA: 0x0003A49E File Offset: 0x0003869E
		public unsafe GameObject palletPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_palletPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_palletPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x002102C0 File Offset: 0x0020E4C0
		// (set) Token: 0x06007AA4 RID: 31396 RVA: 0x0003A4BD File Offset: 0x000386BD
		public unsafe bool orderReceivedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame)) = value;
			}
		}

		// Token: 0x0400536F RID: 21359
		private static readonly IntPtr NativeFieldInfoPtr_pallets;

		// Token: 0x04005370 RID: 21360
		private static readonly IntPtr NativeFieldInfoPtr_palletPrefab;

		// Token: 0x04005371 RID: 21361
		private static readonly IntPtr NativeFieldInfoPtr_orderReceivedThisFrame;

		// Token: 0x04005372 RID: 21362
		private static readonly IntPtr NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0;

		// Token: 0x04005373 RID: 21363
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0;

		// Token: 0x04005374 RID: 21364
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Void_0;

		// Token: 0x04005375 RID: 21365
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x04005376 RID: 21366
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0;

		// Token: 0x04005377 RID: 21367
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0;

		// Token: 0x04005378 RID: 21368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
