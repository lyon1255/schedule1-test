using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039C RID: 924
	public class IUsable : Il2CppObjectBase
	{
		// Token: 0x06004880 RID: 18560 RVA: 0x00162B74 File Offset: 0x00160D74
		// Note: this type is marked as 'beforefieldinit'.
		static IUsable()
		{
			Il2CppClassPointerStore<IUsable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "IUsable");
			IUsable.NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672284);
			IUsable.NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672285);
			IUsable.NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672286);
			IUsable.NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672287);
			IUsable.NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672288);
			IUsable.NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672289);
			IUsable.NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUsable>.NativeClassPtr, 100672290);
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06004881 RID: 18561 RVA: 0x00162C28 File Offset: 0x00160E28
		public unsafe virtual bool IsInUse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162342, XrefRangeEnd = 162349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06004882 RID: 18562 RVA: 0x00162C70 File Offset: 0x00160E70
		// (set) Token: 0x06004883 RID: 18563 RVA: 0x00162CBC File Offset: 0x00160EBC
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06004884 RID: 18564 RVA: 0x00162D0C File Offset: 0x00160F0C
		// (set) Token: 0x06004885 RID: 18565 RVA: 0x00162D58 File Offset: 0x00160F58
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x00162DA8 File Offset: 0x00160FA8
		[CallerCount(0)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00162DF8 File Offset: 0x00160FF8
		[CallerCount(0)]
		public unsafe virtual void SetNPCUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUsable.NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x00022F4F File Offset: 0x0002114F
		public IUsable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030E9 RID: 12521
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInUse_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040030EA RID: 12522
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x040030EB RID: 12523
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0;

		// Token: 0x040030EC RID: 12524
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Abstract_Virtual_New_get_NetworkObject_0;

		// Token: 0x040030ED RID: 12525
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Abstract_Virtual_New_set_Void_NetworkObject_0;

		// Token: 0x040030EE RID: 12526
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Abstract_Virtual_New_Void_NetworkObject_0;

		// Token: 0x040030EF RID: 12527
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Abstract_Virtual_New_Void_NetworkObject_0;
	}
}
