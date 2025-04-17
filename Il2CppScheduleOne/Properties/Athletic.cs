using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001D3 RID: 467
	public class Athletic : Property
	{
		// Token: 0x0600275A RID: 10074 RVA: 0x000EBE94 File Offset: 0x000EA094
		// Note: this type is marked as 'beforefieldinit'.
		static Athletic()
		{
			Il2CppClassPointerStore<Athletic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Athletic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Athletic>.NativeClassPtr);
			Athletic.NativeFieldInfoPtr_SPEED_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Athletic>.NativeClassPtr, "SPEED_MULTIPLIER");
			Athletic.NativeFieldInfoPtr_TintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Athletic>.NativeClassPtr, "TintColor");
			Athletic.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100667690);
			Athletic.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100667691);
			Athletic.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100667692);
			Athletic.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100667693);
			Athletic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Athletic>.NativeClassPtr, 100667694);
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000EBF50 File Offset: 0x000EA150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117688, XrefRangeEnd = 117690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000EBFA0 File Offset: 0x000EA1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117690, XrefRangeEnd = 117720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000EBFF0 File Offset: 0x000EA1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117720, XrefRangeEnd = 117722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000EC040 File Offset: 0x000EA240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117722, XrefRangeEnd = 117752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Athletic.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000EC090 File Offset: 0x000EA290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117752, XrefRangeEnd = 117753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Athletic() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Athletic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Athletic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00015BE2 File Offset: 0x00013DE2
		public Athletic(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x000EC0CC File Offset: 0x000EA2CC
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x00015BEB File Offset: 0x00013DEB
		public unsafe static float SPEED_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Athletic.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Athletic.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000EC0E8 File Offset: 0x000EA2E8
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x00015BF9 File Offset: 0x00013DF9
		public unsafe Color TintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Athletic.NativeFieldInfoPtr_TintColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Athletic.NativeFieldInfoPtr_TintColor)) = value;
			}
		}

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeFieldInfoPtr_SPEED_MULTIPLIER;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeFieldInfoPtr_TintColor;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
