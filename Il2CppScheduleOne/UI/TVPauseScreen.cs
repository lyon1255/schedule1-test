using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.TV;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000623 RID: 1571
	public class TVPauseScreen : MonoBehaviour
	{
		// Token: 0x06008A73 RID: 35443 RVA: 0x0024487C File Offset: 0x00242A7C
		// Note: this type is marked as 'beforefieldinit'.
		static TVPauseScreen()
		{
			Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TVPauseScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr);
			TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, "<IsPaused>k__BackingField");
			TVPauseScreen.NativeFieldInfoPtr_App = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, "App");
			TVPauseScreen.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680499);
			TVPauseScreen.NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680500);
			TVPauseScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680501);
			TVPauseScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680502);
			TVPauseScreen.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680503);
			TVPauseScreen.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680504);
			TVPauseScreen.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680505);
			TVPauseScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr, 100680506);
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x06008A74 RID: 35444 RVA: 0x00244974 File Offset: 0x00242B74
		// (set) Token: 0x06008A75 RID: 35445 RVA: 0x002449B0 File Offset: 0x00242BB0
		public unsafe bool IsPaused
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x002449F0 File Offset: 0x00242BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254088, XrefRangeEnd = 254098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x00244A24 File Offset: 0x00242C24
		[CallerCount(0)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x00244A68 File Offset: 0x00242C68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254101, RefRangeEnd = 254105, XrefRangeStart = 254098, XrefRangeEnd = 254101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A79 RID: 35449 RVA: 0x00244A9C File Offset: 0x00242C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254105, XrefRangeEnd = 254108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x00244AD0 File Offset: 0x00242CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254108, XrefRangeEnd = 254109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x00244B04 File Offset: 0x00242D04
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVPauseScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVPauseScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVPauseScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x00042390 File Offset: 0x00040590
		public TVPauseScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x06008A7D RID: 35453 RVA: 0x00244B40 File Offset: 0x00242D40
		// (set) Token: 0x06008A7E RID: 35454 RVA: 0x00042399 File Offset: 0x00040599
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x06008A7F RID: 35455 RVA: 0x00244B68 File Offset: 0x00242D68
		// (set) Token: 0x06008A80 RID: 35456 RVA: 0x000423B4 File Offset: 0x000405B4
		public unsafe TVApp App
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr_App);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVPauseScreen.NativeFieldInfoPtr_App), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DEC RID: 24044
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x04005DED RID: 24045
		private static readonly IntPtr NativeFieldInfoPtr_App;

		// Token: 0x04005DEE RID: 24046
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x04005DEF RID: 24047
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Private_set_Void_Boolean_0;

		// Token: 0x04005DF0 RID: 24048
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005DF1 RID: 24049
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005DF2 RID: 24050
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04005DF3 RID: 24051
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

		// Token: 0x04005DF4 RID: 24052
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04005DF5 RID: 24053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
