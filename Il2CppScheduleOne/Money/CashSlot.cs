using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000725 RID: 1829
	public class CashSlot : HotbarSlot
	{
		// Token: 0x0600A4FE RID: 42238 RVA: 0x00294FA0 File Offset: 0x002931A0
		// Note: this type is marked as 'beforefieldinit'.
		static CashSlot()
		{
			Il2CppClassPointerStore<CashSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "CashSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashSlot>.NativeClassPtr);
			CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, "MAX_CASH_PER_SLOT");
			CashSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683458);
			CashSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683459);
			CashSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlot>.NativeClassPtr, 100683460);
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x00295020 File Offset: 0x00293220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288200, XrefRangeEnd = 288204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x0029506C File Offset: 0x0029326C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CashSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x002950B4 File Offset: 0x002932B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246958, RefRangeEnd = 246960, XrefRangeStart = 246958, XrefRangeEnd = 246960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x00051527 File Offset: 0x0004F727
		public CashSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600A503 RID: 42243 RVA: 0x002950F0 File Offset: 0x002932F0
		// (set) Token: 0x0600A504 RID: 42244 RVA: 0x00051530 File Offset: 0x0004F730
		public unsafe static float MAX_CASH_PER_SLOT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CashSlot.NativeFieldInfoPtr_MAX_CASH_PER_SLOT, (void*)(&value));
			}
		}

		// Token: 0x04006E9D RID: 28317
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CASH_PER_SLOT;

		// Token: 0x04006E9E RID: 28318
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006E9F RID: 28319
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_Boolean_0;

		// Token: 0x04006EA0 RID: 28320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
