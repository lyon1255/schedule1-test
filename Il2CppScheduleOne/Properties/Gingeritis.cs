using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001DD RID: 477
	public class Gingeritis : Property
	{
		// Token: 0x060027AE RID: 10158 RVA: 0x000ED4C0 File Offset: 0x000EB6C0
		// Note: this type is marked as 'beforefieldinit'.
		static Gingeritis()
		{
			Il2CppClassPointerStore<Gingeritis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Gingeritis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gingeritis>.NativeClassPtr);
			Gingeritis.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gingeritis>.NativeClassPtr, "Color");
			Gingeritis.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gingeritis>.NativeClassPtr, 100667740);
			Gingeritis.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gingeritis>.NativeClassPtr, 100667741);
			Gingeritis.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gingeritis>.NativeClassPtr, 100667742);
			Gingeritis.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gingeritis>.NativeClassPtr, 100667743);
			Gingeritis.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gingeritis>.NativeClassPtr, 100667744);
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000ED568 File Offset: 0x000EB768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117932, XrefRangeEnd = 117937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gingeritis.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000ED5B8 File Offset: 0x000EB7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117937, XrefRangeEnd = 117942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gingeritis.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000ED608 File Offset: 0x000EB808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117942, XrefRangeEnd = 117944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gingeritis.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000ED658 File Offset: 0x000EB858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117944, XrefRangeEnd = 117948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gingeritis.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000ED6A8 File Offset: 0x000EB8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gingeritis() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gingeritis>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gingeritis.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00015CDF File Offset: 0x00013EDF
		public Gingeritis(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000ED6E4 File Offset: 0x000EB8E4
		// (set) Token: 0x060027B6 RID: 10166 RVA: 0x00015CE8 File Offset: 0x00013EE8
		public unsafe static Color32 Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Gingeritis.NativeFieldInfoPtr_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Gingeritis.NativeFieldInfoPtr_Color, (void*)(&value));
			}
		}

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
