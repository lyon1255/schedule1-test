using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001E9 RID: 489
	public class Slippery : Property
	{
		// Token: 0x06002814 RID: 10260 RVA: 0x000EEF3C File Offset: 0x000ED13C
		// Note: this type is marked as 'beforefieldinit'.
		static Slippery()
		{
			Il2CppClassPointerStore<Slippery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Slippery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Slippery>.NativeClassPtr);
			Slippery.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slippery>.NativeClassPtr, 100667817);
			Slippery.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slippery>.NativeClassPtr, 100667818);
			Slippery.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slippery>.NativeClassPtr, 100667819);
			Slippery.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slippery>.NativeClassPtr, 100667820);
			Slippery.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slippery>.NativeClassPtr, 100667821);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000EEFD0 File Offset: 0x000ED1D0
		[CallerCount(0)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slippery.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x000EF020 File Offset: 0x000ED220
		[CallerCount(0)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slippery.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000EF070 File Offset: 0x000ED270
		[CallerCount(0)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slippery.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000EF0C0 File Offset: 0x000ED2C0
		[CallerCount(0)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slippery.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000EF110 File Offset: 0x000ED310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Slippery() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slippery>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slippery.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00015DD6 File Offset: 0x00013FD6
		public Slippery(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
