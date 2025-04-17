using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000372 RID: 882
	public class IMessageEntity : Il2CppObjectBase
	{
		// Token: 0x060044C1 RID: 17601 RVA: 0x00153480 File Offset: 0x00151680
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageEntity()
		{
			Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "IMessageEntity");
			IMessageEntity.NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671694);
			IMessageEntity.NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671695);
			IMessageEntity.NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671696);
			IMessageEntity.NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageEntity>.NativeClassPtr, 100671697);
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x001534F8 File Offset: 0x001516F8
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x00153544 File Offset: 0x00151744
		public unsafe virtual MSGConversation MsgConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x00153594 File Offset: 0x00151794
		[CallerCount(0)]
		public unsafe virtual void add_onResponseChosen(ResponseCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x001535E4 File Offset: 0x001517E4
		[CallerCount(0)]
		public unsafe virtual void remove_onResponseChosen(ResponseCallback value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageEntity.NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x000218E1 File Offset: 0x0001FAE1
		public IMessageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeMethodInfoPtr_get_MsgConversation_Public_Abstract_Virtual_New_get_MSGConversation_0;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeMethodInfoPtr_set_MsgConversation_Public_Abstract_Virtual_New_set_Void_MSGConversation_0;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeMethodInfoPtr_add_onResponseChosen_Public_Abstract_Virtual_New_add_Void_ResponseCallback_0;

		// Token: 0x04002E11 RID: 11793
		private static readonly IntPtr NativeMethodInfoPtr_remove_onResponseChosen_Public_Abstract_Virtual_New_rem_Void_ResponseCallback_0;
	}
}
