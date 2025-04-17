using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001D5 RID: 469
	public class BrightEyed : Property
	{
		// Token: 0x0600276C RID: 10092 RVA: 0x000EC320 File Offset: 0x000EA520
		// Note: this type is marked as 'beforefieldinit'.
		static BrightEyed()
		{
			Il2CppClassPointerStore<BrightEyed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "BrightEyed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr);
			BrightEyed.NativeFieldInfoPtr_EyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "EyeColor");
			BrightEyed.NativeFieldInfoPtr_Emission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "Emission");
			BrightEyed.NativeFieldInfoPtr_LightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, "LightIntensity");
			BrightEyed.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667700);
			BrightEyed.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667701);
			BrightEyed.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667702);
			BrightEyed.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667703);
			BrightEyed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr, 100667704);
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x000EC3F0 File Offset: 0x000EA5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117761, XrefRangeEnd = 117763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x000EC440 File Offset: 0x000EA640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117763, XrefRangeEnd = 117765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x000EC490 File Offset: 0x000EA690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117765, XrefRangeEnd = 117767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000EC4E0 File Offset: 0x000EA6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117767, XrefRangeEnd = 117769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrightEyed.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000EC530 File Offset: 0x000EA730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117769, XrefRangeEnd = 117770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrightEyed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrightEyed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrightEyed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00015C1D File Offset: 0x00013E1D
		public BrightEyed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000EC56C File Offset: 0x000EA76C
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x00015C26 File Offset: 0x00013E26
		public unsafe Color EyeColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_EyeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_EyeColor)) = value;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000EC594 File Offset: 0x000EA794
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x00015C41 File Offset: 0x00013E41
		public unsafe float Emission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_Emission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_Emission)) = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000EC5BC File Offset: 0x000EA7BC
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x00015C5C File Offset: 0x00013E5C
		public unsafe float LightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_LightIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrightEyed.NativeFieldInfoPtr_LightIntensity)) = value;
			}
		}

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeFieldInfoPtr_EyeColor;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeFieldInfoPtr_Emission;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeFieldInfoPtr_LightIntensity;

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
