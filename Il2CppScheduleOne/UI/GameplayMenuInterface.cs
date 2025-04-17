using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063C RID: 1596
	public class GameplayMenuInterface : Singleton<GameplayMenuInterface>
	{
		// Token: 0x06008D0D RID: 36109 RVA: 0x0024C70C File Offset: 0x0024A90C
		// Note: this type is marked as 'beforefieldinit'.
		static GameplayMenuInterface()
		{
			Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GameplayMenuInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr);
			GameplayMenuInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "Canvas");
			GameplayMenuInterface.NativeFieldInfoPtr_PhoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "PhoneButton");
			GameplayMenuInterface.NativeFieldInfoPtr_CharacterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "CharacterButton");
			GameplayMenuInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "SelectionIndicator");
			GameplayMenuInterface.NativeFieldInfoPtr_CharacterInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "CharacterInterface");
			GameplayMenuInterface.NativeFieldInfoPtr_selectionLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "selectionLerp");
			GameplayMenuInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100680824);
			GameplayMenuInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100680825);
			GameplayMenuInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100680826);
			GameplayMenuInterface.NativeMethodInfoPtr_PhoneClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100680827);
			GameplayMenuInterface.NativeMethodInfoPtr_CharacterClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100680828);
			GameplayMenuInterface.NativeMethodInfoPtr_SetSelected_Public_Void_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100680829);
			GameplayMenuInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100680830);
		}

		// Token: 0x06008D0E RID: 36110 RVA: 0x0024C840 File Offset: 0x0024AA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257502, XrefRangeEnd = 257520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenuInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D0F RID: 36111 RVA: 0x0024C87C File Offset: 0x0024AA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257520, XrefRangeEnd = 257522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D10 RID: 36112 RVA: 0x0024C8B0 File Offset: 0x0024AAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257522, XrefRangeEnd = 257524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D11 RID: 36113 RVA: 0x0024C8E4 File Offset: 0x0024AAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257524, XrefRangeEnd = 257530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_PhoneClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D12 RID: 36114 RVA: 0x0024C918 File Offset: 0x0024AB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257530, XrefRangeEnd = 257536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_CharacterClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D13 RID: 36115 RVA: 0x0024C94C File Offset: 0x0024AB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257562, RefRangeEnd = 257563, XrefRangeStart = 257536, XrefRangeEnd = 257562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelected(GameplayMenu.EGameplayScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_SetSelected_Public_Void_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x0024C98C File Offset: 0x0024AB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257563, XrefRangeEnd = 257566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameplayMenuInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x00043A90 File Offset: 0x00041C90
		public GameplayMenuInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x06008D16 RID: 36118 RVA: 0x0024C9C8 File Offset: 0x0024ABC8
		// (set) Token: 0x06008D17 RID: 36119 RVA: 0x00043A99 File Offset: 0x00041C99
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x06008D18 RID: 36120 RVA: 0x0024C9F8 File Offset: 0x0024ABF8
		// (set) Token: 0x06008D19 RID: 36121 RVA: 0x00043AB8 File Offset: 0x00041CB8
		public unsafe Button PhoneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_PhoneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_PhoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x06008D1A RID: 36122 RVA: 0x0024CA28 File Offset: 0x0024AC28
		// (set) Token: 0x06008D1B RID: 36123 RVA: 0x00043AD7 File Offset: 0x00041CD7
		public unsafe Button CharacterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_CharacterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_CharacterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x06008D1C RID: 36124 RVA: 0x0024CA58 File Offset: 0x0024AC58
		// (set) Token: 0x06008D1D RID: 36125 RVA: 0x00043AF6 File Offset: 0x00041CF6
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x06008D1E RID: 36126 RVA: 0x0024CA88 File Offset: 0x0024AC88
		// (set) Token: 0x06008D1F RID: 36127 RVA: 0x00043B15 File Offset: 0x00041D15
		public unsafe CharacterInterface CharacterInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_CharacterInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_CharacterInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x06008D20 RID: 36128 RVA: 0x0024CAB8 File Offset: 0x0024ACB8
		// (set) Token: 0x06008D21 RID: 36129 RVA: 0x00043B34 File Offset: 0x00041D34
		public unsafe Coroutine selectionLerp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_selectionLerp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_selectionLerp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F92 RID: 24466
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005F93 RID: 24467
		private static readonly IntPtr NativeFieldInfoPtr_PhoneButton;

		// Token: 0x04005F94 RID: 24468
		private static readonly IntPtr NativeFieldInfoPtr_CharacterButton;

		// Token: 0x04005F95 RID: 24469
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04005F96 RID: 24470
		private static readonly IntPtr NativeFieldInfoPtr_CharacterInterface;

		// Token: 0x04005F97 RID: 24471
		private static readonly IntPtr NativeFieldInfoPtr_selectionLerp;

		// Token: 0x04005F98 RID: 24472
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005F99 RID: 24473
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005F9A RID: 24474
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005F9B RID: 24475
		private static readonly IntPtr NativeMethodInfoPtr_PhoneClicked_Public_Void_0;

		// Token: 0x04005F9C RID: 24476
		private static readonly IntPtr NativeMethodInfoPtr_CharacterClicked_Public_Void_0;

		// Token: 0x04005F9D RID: 24477
		private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_EGameplayScreen_0;

		// Token: 0x04005F9E RID: 24478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B22 RID: 2850
		[ObfuscatedName("ScheduleOne.UI.GameplayMenuInterface+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D772 RID: 55154 RVA: 0x003339A4 File Offset: 0x00331BA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr);
				GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, "pos");
				GameplayMenuInterface.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, 100680831);
				GameplayMenuInterface.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, 100680832);
			}

			// Token: 0x0600D773 RID: 55155 RVA: 0x00333A20 File Offset: 0x00331C20
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D774 RID: 55156 RVA: 0x00333A5C File Offset: 0x00331C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257497, XrefRangeEnd = 257502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D775 RID: 55157 RVA: 0x00068E4E File Offset: 0x0006704E
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C7 RID: 17095
			// (get) Token: 0x0600D776 RID: 55158 RVA: 0x00333A9C File Offset: 0x00331C9C
			// (set) Token: 0x0600D777 RID: 55159 RVA: 0x00068E57 File Offset: 0x00067057
			public unsafe GameplayMenuInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenuInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C8 RID: 17096
			// (get) Token: 0x0600D778 RID: 55160 RVA: 0x00333ACC File Offset: 0x00331CCC
			// (set) Token: 0x0600D779 RID: 55161 RVA: 0x00068E76 File Offset: 0x00067076
			public unsafe Vector2 pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x040090D6 RID: 37078
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090D7 RID: 37079
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x040090D8 RID: 37080
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090D9 RID: 37081
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C72 RID: 3186
			[ObfuscatedName("ScheduleOne.UI.GameplayMenuInterface+<>c__DisplayClass11_0+<<SetSelected>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E547 RID: 58695 RVA: 0x0035B7B0 File Offset: 0x003599B0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, "<<SetSelected>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startX_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startX>5__2");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<t>5__3");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680833);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680834);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680835);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680836);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680837);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100680838);
				}

				// Token: 0x0600E548 RID: 58696 RVA: 0x0035B8B8 File Offset: 0x00359AB8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E549 RID: 58697 RVA: 0x0035B900 File Offset: 0x00359B00
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E54A RID: 58698 RVA: 0x0035B934 File Offset: 0x00359B34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257477, XrefRangeEnd = 257492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700474C RID: 18252
				// (get) Token: 0x0600E54B RID: 58699 RVA: 0x0035B970 File Offset: 0x00359B70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E54C RID: 58700 RVA: 0x0035B9B0 File Offset: 0x00359BB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257492, XrefRangeEnd = 257497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700474D RID: 18253
				// (get) Token: 0x0600E54D RID: 58701 RVA: 0x0035B9E4 File Offset: 0x00359BE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E54E RID: 58702 RVA: 0x0006FD26 File Offset: 0x0006DF26
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004747 RID: 18247
				// (get) Token: 0x0600E54F RID: 58703 RVA: 0x0035BA24 File Offset: 0x00359C24
				// (set) Token: 0x0600E550 RID: 58704 RVA: 0x0006FD2F File Offset: 0x0006DF2F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004748 RID: 18248
				// (get) Token: 0x0600E551 RID: 58705 RVA: 0x0035BA4C File Offset: 0x00359C4C
				// (set) Token: 0x0600E552 RID: 58706 RVA: 0x0006FD4A File Offset: 0x0006DF4A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004749 RID: 18249
				// (get) Token: 0x0600E553 RID: 58707 RVA: 0x0035BA7C File Offset: 0x00359C7C
				// (set) Token: 0x0600E554 RID: 58708 RVA: 0x0006FD69 File Offset: 0x0006DF69
				public unsafe GameplayMenuInterface.__c__DisplayClass11_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenuInterface.__c__DisplayClass11_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700474A RID: 18250
				// (get) Token: 0x0600E555 RID: 58709 RVA: 0x0035BAAC File Offset: 0x00359CAC
				// (set) Token: 0x0600E556 RID: 58710 RVA: 0x0006FD88 File Offset: 0x0006DF88
				public unsafe float _startX_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startX_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startX_5__2)) = value;
					}
				}

				// Token: 0x1700474B RID: 18251
				// (get) Token: 0x0600E557 RID: 58711 RVA: 0x0035BAD4 File Offset: 0x00359CD4
				// (set) Token: 0x0600E558 RID: 58712 RVA: 0x0006FDA3 File Offset: 0x0006DFA3
				public unsafe float _t_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__t_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__t_5__3)) = value;
					}
				}

				// Token: 0x04009951 RID: 39249
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009952 RID: 39250
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009953 RID: 39251
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009954 RID: 39252
				private static readonly IntPtr NativeFieldInfoPtr__startX_5__2;

				// Token: 0x04009955 RID: 39253
				private static readonly IntPtr NativeFieldInfoPtr__t_5__3;

				// Token: 0x04009956 RID: 39254
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009957 RID: 39255
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009958 RID: 39256
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009959 RID: 39257
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400995A RID: 39258
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400995B RID: 39259
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
