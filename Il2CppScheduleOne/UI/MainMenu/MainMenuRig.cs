using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E8 RID: 1768
	public class MainMenuRig : MonoBehaviour
	{
		// Token: 0x06009E50 RID: 40528 RVA: 0x00280078 File Offset: 0x0027E278
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuRig()
		{
			Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuRig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr);
			MainMenuRig.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "Avatar");
			MainMenuRig.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "DefaultSettings");
			MainMenuRig.NativeFieldInfoPtr_CashPiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, "CashPiles");
			MainMenuRig.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100682721);
			MainMenuRig.NativeMethodInfoPtr_LoadStuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100682722);
			MainMenuRig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr, 100682723);
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x00280120 File Offset: 0x0027E320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279923, XrefRangeEnd = 279935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x00280154 File Offset: 0x0027E354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279935, XrefRangeEnd = 279975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr_LoadStuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x00280188 File Offset: 0x0027E388
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuRig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuRig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuRig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x0004DA4A File Offset: 0x0004BC4A
		public MainMenuRig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x06009E55 RID: 40533 RVA: 0x002801C4 File Offset: 0x0027E3C4
		// (set) Token: 0x06009E56 RID: 40534 RVA: 0x0004DA53 File Offset: 0x0004BC53
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x06009E57 RID: 40535 RVA: 0x002801F4 File Offset: 0x0027E3F4
		// (set) Token: 0x06009E58 RID: 40536 RVA: 0x0004DA72 File Offset: 0x0004BC72
		public unsafe BasicAvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030BD RID: 12477
		// (get) Token: 0x06009E59 RID: 40537 RVA: 0x00280224 File Offset: 0x0027E424
		// (set) Token: 0x06009E5A RID: 40538 RVA: 0x0004DA91 File Offset: 0x0004BC91
		public unsafe Il2CppReferenceArray<CashPile> CashPiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_CashPiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CashPile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuRig.NativeFieldInfoPtr_CashPiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A43 RID: 27203
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04006A44 RID: 27204
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04006A45 RID: 27205
		private static readonly IntPtr NativeFieldInfoPtr_CashPiles;

		// Token: 0x04006A46 RID: 27206
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006A47 RID: 27207
		private static readonly IntPtr NativeMethodInfoPtr_LoadStuff_Private_Void_0;

		// Token: 0x04006A48 RID: 27208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
