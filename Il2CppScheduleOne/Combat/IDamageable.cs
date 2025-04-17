using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000492 RID: 1170
	public class IDamageable : Il2CppObjectBase
	{
		// Token: 0x0600652F RID: 25903 RVA: 0x001C8ED0 File Offset: 0x001C70D0
		// Note: this type is marked as 'beforefieldinit'.
		static IDamageable()
		{
			Il2CppClassPointerStore<IDamageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "IDamageable");
			IDamageable.NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100676106);
			IDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDamageable>.NativeClassPtr, 100676107);
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x001C8F20 File Offset: 0x001C7120
		[CallerCount(0)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x001C8F70 File Offset: 0x001C7170
		[CallerCount(0)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x0002FD8D File Offset: 0x0002DF8D
		public IDamageable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400450D RID: 17677
		private static readonly IntPtr NativeMethodInfoPtr_SendImpact_Public_Abstract_Virtual_New_Void_Impact_0;

		// Token: 0x0400450E RID: 17678
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Abstract_Virtual_New_Void_Impact_0;
	}
}
