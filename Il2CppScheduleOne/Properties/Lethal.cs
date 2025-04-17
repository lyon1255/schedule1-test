using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001E2 RID: 482
	public class Lethal : Property
	{
		// Token: 0x060027D5 RID: 10197 RVA: 0x000EDF7C File Offset: 0x000EC17C
		// Note: this type is marked as 'beforefieldinit'.
		static Lethal()
		{
			Il2CppClassPointerStore<Lethal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Lethal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lethal>.NativeClassPtr);
			Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lethal>.NativeClassPtr, "HEALTH_DRAIN_PLAYER");
			Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lethal>.NativeClassPtr, "HEALTH_DRAIN_NPC");
			Lethal.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667766);
			Lethal.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667767);
			Lethal.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667768);
			Lethal.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667769);
			Lethal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lethal>.NativeClassPtr, 100667770);
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x000EE038 File Offset: 0x000EC238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117992, XrefRangeEnd = 117998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000EE088 File Offset: 0x000EC288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117998, XrefRangeEnd = 118017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000EE0D8 File Offset: 0x000EC2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118017, XrefRangeEnd = 118022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000EE128 File Offset: 0x000EC328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118022, XrefRangeEnd = 118040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lethal.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000EE178 File Offset: 0x000EC378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lethal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lethal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lethal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00015D35 File Offset: 0x00013F35
		public Lethal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x000EE1B4 File Offset: 0x000EC3B4
		// (set) Token: 0x060027DD RID: 10205 RVA: 0x00015D3E File Offset: 0x00013F3E
		public unsafe static float HEALTH_DRAIN_PLAYER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER, (void*)(&value));
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x000EE1D0 File Offset: 0x000EC3D0
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x00015D4C File Offset: 0x00013F4C
		public unsafe static float HEALTH_DRAIN_NPC
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lethal.NativeFieldInfoPtr_HEALTH_DRAIN_NPC, (void*)(&value));
			}
		}

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_DRAIN_PLAYER;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_DRAIN_NPC;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
