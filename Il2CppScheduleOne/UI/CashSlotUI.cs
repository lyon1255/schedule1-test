using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000642 RID: 1602
	public class CashSlotUI : ItemSlotUI
	{
		// Token: 0x06008DF1 RID: 36337 RVA: 0x0024F038 File Offset: 0x0024D238
		// Note: this type is marked as 'beforefieldinit'.
		static CashSlotUI()
		{
			Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CashSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr);
			CashSlotUI.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr, "cashInstance");
			CashSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr, 100680925);
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x0024F090 File Offset: 0x0024D290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258283, XrefRangeEnd = 258284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x000443A9 File Offset: 0x000425A9
		public CashSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x06008DF4 RID: 36340 RVA: 0x0024F0CC File Offset: 0x0024D2CC
		// (set) Token: 0x06008DF5 RID: 36341 RVA: 0x000443B2 File Offset: 0x000425B2
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashSlotUI.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashSlotUI.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400601E RID: 24606
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x0400601F RID: 24607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
