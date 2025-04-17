using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001E8 RID: 488
	public class Shrinking : Property
	{
		// Token: 0x06002809 RID: 10249 RVA: 0x000EECCC File Offset: 0x000ECECC
		// Note: this type is marked as 'beforefieldinit'.
		static Shrinking()
		{
			Il2CppClassPointerStore<Shrinking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Shrinking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Shrinking>.NativeClassPtr);
			Shrinking.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, "Scale");
			Shrinking.NativeFieldInfoPtr_LerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, "LerpTime");
			Shrinking.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667812);
			Shrinking.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667813);
			Shrinking.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667814);
			Shrinking.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667815);
			Shrinking.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Shrinking>.NativeClassPtr, 100667816);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000EED88 File Offset: 0x000ECF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118245, XrefRangeEnd = 118246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x000EEDD8 File Offset: 0x000ECFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118246, XrefRangeEnd = 118248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000EEE28 File Offset: 0x000ED028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118248, XrefRangeEnd = 118249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000EEE78 File Offset: 0x000ED078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118249, XrefRangeEnd = 118251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Shrinking.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000EEEC8 File Offset: 0x000ED0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Shrinking() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Shrinking>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Shrinking.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00015DB1 File Offset: 0x00013FB1
		public Shrinking(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x000EEF04 File Offset: 0x000ED104
		// (set) Token: 0x06002811 RID: 10257 RVA: 0x00015DBA File Offset: 0x00013FBA
		public unsafe static float Scale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Shrinking.NativeFieldInfoPtr_Scale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shrinking.NativeFieldInfoPtr_Scale, (void*)(&value));
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x000EEF20 File Offset: 0x000ED120
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x00015DC8 File Offset: 0x00013FC8
		public unsafe static float LerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Shrinking.NativeFieldInfoPtr_LerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Shrinking.NativeFieldInfoPtr_LerpTime, (void*)(&value));
			}
		}

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeFieldInfoPtr_LerpTime;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
