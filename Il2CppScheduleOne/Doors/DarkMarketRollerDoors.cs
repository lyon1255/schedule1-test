using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x0200041F RID: 1055
	public class DarkMarketRollerDoors : SensorRollerDoors
	{
		// Token: 0x06005CEF RID: 23791 RVA: 0x001AD9A4 File Offset: 0x001ABBA4
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketRollerDoors()
		{
			Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DarkMarketRollerDoors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr);
			DarkMarketRollerDoors.NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr, 100675145);
			DarkMarketRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr, 100675146);
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x001AD9FC File Offset: 0x001ABBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195564, XrefRangeEnd = 195568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarketRollerDoors.NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x001ADA44 File Offset: 0x001ABC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195568, XrefRangeEnd = 195571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketRollerDoors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketRollerDoors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x0002BCBF File Offset: 0x00029EBF
		public DarkMarketRollerDoors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003F96 RID: 16278
		private static readonly IntPtr NativeMethodInfoPtr_CanOpen_Protected_Virtual_Boolean_0;

		// Token: 0x04003F97 RID: 16279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
