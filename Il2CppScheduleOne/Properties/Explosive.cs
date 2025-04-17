using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001DB RID: 475
	public class Explosive : Property
	{
		// Token: 0x060027A0 RID: 10144 RVA: 0x000ED0A0 File Offset: 0x000EB2A0
		// Note: this type is marked as 'beforefieldinit'.
		static Explosive()
		{
			Il2CppClassPointerStore<Explosive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Explosive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Explosive>.NativeClassPtr);
			Explosive.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosive>.NativeClassPtr, 100667730);
			Explosive.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosive>.NativeClassPtr, 100667731);
			Explosive.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosive>.NativeClassPtr, 100667732);
			Explosive.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosive>.NativeClassPtr, 100667733);
			Explosive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosive>.NativeClassPtr, 100667734);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000ED134 File Offset: 0x000EB334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117904, XrefRangeEnd = 117906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Explosive.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x000ED184 File Offset: 0x000EB384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117906, XrefRangeEnd = 117908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Explosive.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000ED1D4 File Offset: 0x000EB3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117908, XrefRangeEnd = 117910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Explosive.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000ED224 File Offset: 0x000EB424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117910, XrefRangeEnd = 117912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Explosive.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000ED274 File Offset: 0x000EB474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Explosive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Explosive>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00015CCD File Offset: 0x00013ECD
		public Explosive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
