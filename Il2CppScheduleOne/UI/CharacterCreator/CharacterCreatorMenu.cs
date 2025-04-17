using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FE RID: 1790
	public class CharacterCreatorMenu : MonoBehaviour
	{
		// Token: 0x0600A095 RID: 41109 RVA: 0x00286DD4 File Offset: 0x00284FD4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorMenu()
		{
			Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr);
			CharacterCreatorMenu.NativeFieldInfoPtr_Windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "Windows");
			CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "CategoryLabel");
			CharacterCreatorMenu.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "BackButton");
			CharacterCreatorMenu.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "NextButton");
			CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "openWindowIndex");
			CharacterCreatorMenu.NativeFieldInfoPtr_openWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "openWindow");
			CharacterCreatorMenu.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682939);
			CharacterCreatorMenu.NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682940);
			CharacterCreatorMenu.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682941);
			CharacterCreatorMenu.NativeMethodInfoPtr_Next_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682942);
			CharacterCreatorMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100682943);
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x00286EE0 File Offset: 0x002850E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282389, XrefRangeEnd = 282395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x00286F14 File Offset: 0x00285114
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282404, RefRangeEnd = 282407, XrefRangeStart = 282395, XrefRangeEnd = 282404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenWindow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x00286F54 File Offset: 0x00285154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282407, XrefRangeEnd = 282408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x00286F88 File Offset: 0x00285188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282408, XrefRangeEnd = 282409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Next_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x00286FBC File Offset: 0x002851BC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x0004EF9B File Offset: 0x0004D19B
		public CharacterCreatorMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600A09C RID: 41116 RVA: 0x00286FF8 File Offset: 0x002851F8
		// (set) Token: 0x0600A09D RID: 41117 RVA: 0x0004EFA4 File Offset: 0x0004D1A4
		public unsafe Il2CppReferenceArray<CharacterCreatorMenu.Window> Windows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_Windows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCreatorMenu.Window>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_Windows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600A09E RID: 41118 RVA: 0x00287028 File Offset: 0x00285228
		// (set) Token: 0x0600A09F RID: 41119 RVA: 0x0004EFC3 File Offset: 0x0004D1C3
		public unsafe TextMeshProUGUI CategoryLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x00287058 File Offset: 0x00285258
		// (set) Token: 0x0600A0A1 RID: 41121 RVA: 0x0004EFE2 File Offset: 0x0004D1E2
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600A0A2 RID: 41122 RVA: 0x00287088 File Offset: 0x00285288
		// (set) Token: 0x0600A0A3 RID: 41123 RVA: 0x0004F001 File Offset: 0x0004D201
		public unsafe Button NextButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_NextButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600A0A4 RID: 41124 RVA: 0x002870B8 File Offset: 0x002852B8
		// (set) Token: 0x0600A0A5 RID: 41125 RVA: 0x0004F020 File Offset: 0x0004D220
		public unsafe int openWindowIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex)) = value;
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x002870E0 File Offset: 0x002852E0
		// (set) Token: 0x0600A0A7 RID: 41127 RVA: 0x0004F03B File Offset: 0x0004D23B
		public unsafe CharacterCreatorMenu.Window openWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorMenu.Window>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006BA8 RID: 27560
		private static readonly IntPtr NativeFieldInfoPtr_Windows;

		// Token: 0x04006BA9 RID: 27561
		private static readonly IntPtr NativeFieldInfoPtr_CategoryLabel;

		// Token: 0x04006BAA RID: 27562
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04006BAB RID: 27563
		private static readonly IntPtr NativeFieldInfoPtr_NextButton;

		// Token: 0x04006BAC RID: 27564
		private static readonly IntPtr NativeFieldInfoPtr_openWindowIndex;

		// Token: 0x04006BAD RID: 27565
		private static readonly IntPtr NativeFieldInfoPtr_openWindow;

		// Token: 0x04006BAE RID: 27566
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006BAF RID: 27567
		private static readonly IntPtr NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0;

		// Token: 0x04006BB0 RID: 27568
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04006BB1 RID: 27569
		private static readonly IntPtr NativeMethodInfoPtr_Next_Public_Void_0;

		// Token: 0x04006BB2 RID: 27570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAB RID: 2987
		[Serializable]
		public class Window : Il2CppSystem.Object
		{
			// Token: 0x0600DCDC RID: 56540 RVA: 0x00343114 File Offset: 0x00341314
			// Note: this type is marked as 'beforefieldinit'.
			static Window()
			{
				Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "Window");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr);
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Name");
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Container");
				CharacterCreatorMenu.Window.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100682944);
				CharacterCreatorMenu.Window.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100682945);
				CharacterCreatorMenu.Window.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100682946);
			}

			// Token: 0x0600DCDD RID: 56541 RVA: 0x003431A4 File Offset: 0x003413A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282383, XrefRangeEnd = 282386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Open()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCDE RID: 56542 RVA: 0x003431D8 File Offset: 0x003413D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282386, XrefRangeEnd = 282389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCDF RID: 56543 RVA: 0x0034320C File Offset: 0x0034140C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Window() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCE0 RID: 56544 RVA: 0x0006BA01 File Offset: 0x00069C01
			public Window(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004475 RID: 17525
			// (get) Token: 0x0600DCE1 RID: 56545 RVA: 0x00343248 File Offset: 0x00341448
			// (set) Token: 0x0600DCE2 RID: 56546 RVA: 0x0006BA0A File Offset: 0x00069C0A
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004476 RID: 17526
			// (get) Token: 0x0600DCE3 RID: 56547 RVA: 0x00343270 File Offset: 0x00341470
			// (set) Token: 0x0600DCE4 RID: 56548 RVA: 0x0006BA29 File Offset: 0x00069C29
			public unsafe RectTransform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009400 RID: 37888
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009401 RID: 37889
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04009402 RID: 37890
			private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

			// Token: 0x04009403 RID: 37891
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

			// Token: 0x04009404 RID: 37892
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
