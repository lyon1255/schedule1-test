using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000658 RID: 1624
	public class IPostSleepEvent : Il2CppObjectBase
	{
		// Token: 0x06009101 RID: 37121 RVA: 0x00257DD8 File Offset: 0x00255FD8
		// Note: this type is marked as 'beforefieldinit'.
		static IPostSleepEvent()
		{
			Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "IPostSleepEvent");
			IPostSleepEvent.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681258);
			IPostSleepEvent.NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681259);
			IPostSleepEvent.NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPostSleepEvent>.NativeClassPtr, 100681260);
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x06009102 RID: 37122 RVA: 0x00257E3C File Offset: 0x0025603C
		public unsafe virtual bool IsRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x06009103 RID: 37123 RVA: 0x00257E84 File Offset: 0x00256084
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x00257ECC File Offset: 0x002560CC
		[CallerCount(0)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPostSleepEvent.NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x00046142 File Offset: 0x00044342
		public IPostSleepEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006205 RID: 25093
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04006206 RID: 25094
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04006207 RID: 25095
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Abstract_Virtual_New_Void_0;
	}
}
