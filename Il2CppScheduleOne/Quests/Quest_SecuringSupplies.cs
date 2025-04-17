using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C2 RID: 450
	public class Quest_SecuringSupplies : Quest
	{
		// Token: 0x0600267C RID: 9852 RVA: 0x000E9434 File Offset: 0x000E7634
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_SecuringSupplies()
		{
			Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_SecuringSupplies");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr);
			Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, "Supplier");
			Quest_SecuringSupplies.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, 100667597);
			Quest_SecuringSupplies.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr, 100667598);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x000E94A0 File Offset: 0x000E76A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116968, XrefRangeEnd = 116970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SecuringSupplies.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x000E94DC File Offset: 0x000E76DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116970, XrefRangeEnd = 116974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_SecuringSupplies() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_SecuringSupplies>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SecuringSupplies.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00015564 File Offset: 0x00013764
		public Quest_SecuringSupplies(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x000E9518 File Offset: 0x000E7718
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x0001556D File Offset: 0x0001376D
		public unsafe Supplier Supplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SecuringSupplies.NativeFieldInfoPtr_Supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeFieldInfoPtr_Supplier;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
