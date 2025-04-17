using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000529 RID: 1321
	public class InputFieldAttachment : MonoBehaviour
	{
		// Token: 0x06007626 RID: 30246 RVA: 0x00202464 File Offset: 0x00200664
		// Note: this type is marked as 'beforefieldinit'.
		static InputFieldAttachment()
		{
			Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "InputFieldAttachment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr);
			InputFieldAttachment.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678183);
			InputFieldAttachment.NativeMethodInfoPtr_EditStart_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678184);
			InputFieldAttachment.NativeMethodInfoPtr_EndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678185);
			InputFieldAttachment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, 100678186);
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x002024E4 File Offset: 0x002006E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230503, XrefRangeEnd = 230567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00202518 File Offset: 0x00200718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230567, XrefRangeEnd = 230571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditStart(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_EditStart_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x0020255C File Offset: 0x0020075C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230571, XrefRangeEnd = 230575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEdit(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr_EndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x002025A0 File Offset: 0x002007A0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputFieldAttachment() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00037FBD File Offset: 0x000361BD
		public InputFieldAttachment(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040050BD RID: 20669
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040050BE RID: 20670
		private static readonly IntPtr NativeMethodInfoPtr_EditStart_Private_Void_String_0;

		// Token: 0x040050BF RID: 20671
		private static readonly IntPtr NativeMethodInfoPtr_EndEdit_Private_Void_String_0;

		// Token: 0x040050C0 RID: 20672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A96 RID: 2710
		[ObfuscatedName("ScheduleOne.Tools.InputFieldAttachment+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2AD RID: 53933 RVA: 0x0032612C File Offset: 0x0032432C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputFieldAttachment>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr);
				InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
				InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, "inputField");
				InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, 100678187);
				InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr, 100678188);
			}

			// Token: 0x0600D2AE RID: 53934 RVA: 0x003261A8 File Offset: 0x003243A8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFieldAttachment.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2AF RID: 53935 RVA: 0x003261E4 File Offset: 0x003243E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230499, XrefRangeEnd = 230503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFieldAttachment.__c__DisplayClass0_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2B0 RID: 53936 RVA: 0x000668E1 File Offset: 0x00064AE1
			public __c__DisplayClass0_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700415B RID: 16731
			// (get) Token: 0x0600D2B1 RID: 53937 RVA: 0x00326228 File Offset: 0x00324428
			// (set) Token: 0x0600D2B2 RID: 53938 RVA: 0x000668EA File Offset: 0x00064AEA
			public unsafe InputFieldAttachment __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputFieldAttachment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700415C RID: 16732
			// (get) Token: 0x0600D2B3 RID: 53939 RVA: 0x00326258 File Offset: 0x00324458
			// (set) Token: 0x0600D2B4 RID: 53940 RVA: 0x00066909 File Offset: 0x00064B09
			public unsafe InputField inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFieldAttachment.__c__DisplayClass0_0.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E06 RID: 36358
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E07 RID: 36359
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x04008E08 RID: 36360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E09 RID: 36361
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_BaseEventData_0;
		}
	}
}
