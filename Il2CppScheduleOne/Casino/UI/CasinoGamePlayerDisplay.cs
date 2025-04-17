using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004AA RID: 1194
	public class CasinoGamePlayerDisplay : MonoBehaviour
	{
		// Token: 0x06006921 RID: 26913 RVA: 0x001D75CC File Offset: 0x001D57CC
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayerDisplay()
		{
			Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "CasinoGamePlayerDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr);
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "BindedPlayers");
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "TitleLabel");
			CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, "PlayerEntries");
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshPlayers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676663);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676664);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676665);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr_Unbind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676666);
			CasinoGamePlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr, 100676667);
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x001D769C File Offset: 0x001D589C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212328, RefRangeEnd = 212329, XrefRangeStart = 212277, XrefRangeEnd = 212328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshPlayers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x001D76D0 File Offset: 0x001D58D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212329, XrefRangeEnd = 212340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_RefreshScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x001D7704 File Offset: 0x001D5904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212356, RefRangeEnd = 212358, XrefRangeStart = 212340, XrefRangeEnd = 212356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(CasinoGamePlayers players)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(players);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x001D7748 File Offset: 0x001D5948
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212376, RefRangeEnd = 212378, XrefRangeStart = 212358, XrefRangeEnd = 212376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unbind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr_Unbind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x001D777C File Offset: 0x001D597C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayerDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x00031A03 File Offset: 0x0002FC03
		public CasinoGamePlayerDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06006928 RID: 26920 RVA: 0x001D77B8 File Offset: 0x001D59B8
		// (set) Token: 0x06006929 RID: 26921 RVA: 0x00031A0C File Offset: 0x0002FC0C
		public unsafe CasinoGamePlayers BindedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_BindedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600692A RID: 26922 RVA: 0x001D77E8 File Offset: 0x001D59E8
		// (set) Token: 0x0600692B RID: 26923 RVA: 0x00031A2B File Offset: 0x0002FC2B
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x0600692C RID: 26924 RVA: 0x001D7818 File Offset: 0x001D5A18
		// (set) Token: 0x0600692D RID: 26925 RVA: 0x00031A4A File Offset: 0x0002FC4A
		public unsafe Il2CppReferenceArray<RectTransform> PlayerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerDisplay.NativeFieldInfoPtr_PlayerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400480D RID: 18445
		private static readonly IntPtr NativeFieldInfoPtr_BindedPlayers;

		// Token: 0x0400480E RID: 18446
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400480F RID: 18447
		private static readonly IntPtr NativeFieldInfoPtr_PlayerEntries;

		// Token: 0x04004810 RID: 18448
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPlayers_Public_Void_0;

		// Token: 0x04004811 RID: 18449
		private static readonly IntPtr NativeMethodInfoPtr_RefreshScores_Public_Void_0;

		// Token: 0x04004812 RID: 18450
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_CasinoGamePlayers_0;

		// Token: 0x04004813 RID: 18451
		private static readonly IntPtr NativeMethodInfoPtr_Unbind_Public_Void_0;

		// Token: 0x04004814 RID: 18452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
