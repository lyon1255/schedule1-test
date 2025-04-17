using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000615 RID: 1557
	public class ACWindow : MonoBehaviour
	{
		// Token: 0x06008977 RID: 35191 RVA: 0x00241A94 File Offset: 0x0023FC94
		// Note: this type is marked as 'beforefieldinit'.
		static ACWindow()
		{
			Il2CppClassPointerStore<ACWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACWindow>.NativeClassPtr);
			ACWindow.NativeFieldInfoPtr_WindowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "WindowTitle");
			ACWindow.NativeFieldInfoPtr_Predecessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "Predecessor");
			ACWindow.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "TitleText");
			ACWindow.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, "BackButton");
			ACWindow.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680411);
			ACWindow.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680412);
			ACWindow.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680413);
			ACWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACWindow>.NativeClassPtr, 100680414);
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x00241B64 File Offset: 0x0023FD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253318, XrefRangeEnd = 253338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x00241B98 File Offset: 0x0023FD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x00241BCC File Offset: 0x0023FDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253338, XrefRangeEnd = 253346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x00241C00 File Offset: 0x0023FE00
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACWindow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACWindow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x00041A25 File Offset: 0x0003FC25
		public ACWindow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x0600897D RID: 35197 RVA: 0x00241C3C File Offset: 0x0023FE3C
		// (set) Token: 0x0600897E RID: 35198 RVA: 0x00041A2E File Offset: 0x0003FC2E
		public unsafe string WindowTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_WindowTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_WindowTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600897F RID: 35199 RVA: 0x00241C64 File Offset: 0x0023FE64
		// (set) Token: 0x06008980 RID: 35200 RVA: 0x00041A4D File Offset: 0x0003FC4D
		public unsafe ACWindow Predecessor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_Predecessor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACWindow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_Predecessor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x06008981 RID: 35201 RVA: 0x00241C94 File Offset: 0x0023FE94
		// (set) Token: 0x06008982 RID: 35202 RVA: 0x00041A6C File Offset: 0x0003FC6C
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x06008983 RID: 35203 RVA: 0x00241CC4 File Offset: 0x0023FEC4
		// (set) Token: 0x06008984 RID: 35204 RVA: 0x00041A8B File Offset: 0x0003FC8B
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACWindow.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D56 RID: 23894
		private static readonly IntPtr NativeFieldInfoPtr_WindowTitle;

		// Token: 0x04005D57 RID: 23895
		private static readonly IntPtr NativeFieldInfoPtr_Predecessor;

		// Token: 0x04005D58 RID: 23896
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04005D59 RID: 23897
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04005D5A RID: 23898
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005D5B RID: 23899
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005D5C RID: 23900
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005D5D RID: 23901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
